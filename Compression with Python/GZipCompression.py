import gzip
import time
import os
import ConvertTo

min_compression_level = 1
max_compression_level = 9
extension = ".gz"

def compress(file_path: str, data_unit: ConvertTo.DataUnits):
    """Compress using the GZip algorithm."""

    log = open("log_compress.txt", "w")
    f_input = open(file_path, 'rb')

    for i in range(min_compression_level, max_compression_level + 1):
        start_timer = time.time()
        
        f_output_path = file_path + str(i) + extension

        f_output = gzip.open(f_output_path, 'wb', compresslevel=i)
        f_output.write(f_input.read())

        f_input.seek(0)
        f_output.close()

        log.write(str(i) + " " + str(ConvertTo.byte_to(os.path.getsize(f_output_path), data_unit)) + " " + str("{0:.2f}".format(time.time() - start_timer)) + " GZIP\n")

    f_input.close()
    log.close()


def decompress(file_path: str):
    """Decompress using the GZip algorithm."""

    log = open("log_decompress.txt", "w")
    f_input = gzip.open(file_path + str(max_compression_level) + extension, 'rb', compresslevel=max_compression_level)
    start_timer = time.time()

    f_output = open(file_path, 'wb')
    f_output.write(f_input.read())

    log.write(file_path + " " + str("{0:.2f}".format(time.time() - start_timer)) + " GZIP\n")

    f_output.close()
    f_input.close()
    log.close()
        