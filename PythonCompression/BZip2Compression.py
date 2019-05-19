import bz2
import time
import os
import ConvertTo

min_compression_level = 1
max_compression_level = 9
extension = ".bz2"

def compress(file_path: str, data_unit: ConvertTo.DataUnits):
    """Compress using the BZip2 algorithm."""

    log = open("Logs/com_bzip2_"  + os.path.basename(file_path) + ".txt", "a")
    f_input = open(file_path, 'rb')

    for i in range(min_compression_level, max_compression_level + 1):
        start_timer = time.time()

        f_output_path = "Temp/" + os.path.basename(file_path) + str(i) + extension

        f_output = bz2.open(f_output_path, 'wb', compresslevel=i)
        f_output.write(f_input.read())

        f_input.seek(0)    
        f_output.close()

        log.write(str(i) + " " + str(ConvertTo.byte_to(os.path.getsize(f_output_path), data_unit)) + " " + str("{0:.2f}".format(time.time() - start_timer)) + " Pyton\n")

    f_input.close()
    log.close()
    return f_output_path

def decompress(file_path: str):
    """Decompress using the BZip2 algorithm."""

    log = open("Logs/dec_bzip2.txt", "a")
    f_input = bz2.open(file_path, 'rb', compresslevel=max_compression_level)
    start_timer = time.time()

    f_output = open(file_path.split(str(max_compression_level) + extension)[0], 'wb')
    f_output.write(f_input.read())

    log.write(os.path.basename(file_path).split(str(max_compression_level) + extension)[0] + " " + str("{0:.2f}".format(time.time() - start_timer)) + " Python\n")

    f_output.close()
    f_input.close()
    log.close()