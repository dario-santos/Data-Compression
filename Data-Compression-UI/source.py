from ConvertTo import DataUnits
import BZip2Compression as BZip2
import GZipCompression as GZip
import sys
import os


def evaluate_file_path() -> str:
    """Evaluates the path to the choosen file to compress from the different possibilities."""

    if len(sys.argv) != 2 and not os.path.isfile("compress.svg"):
        print("\n\nError: Number invalid of arguments, please use the terminal to pass the file") 
        print("or place a compress.svg in the program directory\n\n")
        return None

    #The file to use is the given by the terminal
    if len(sys.argv) == 2:
        
        if not os.path.isfile(sys.argv[1]):
            print("\n\nError: The file passed trougth the terminal does not exists.\n\n")
            return  None
        else:
            return sys.argv[1]

    #The file to compress is the default one
    if os.path.isfile("compress.svg"):
        return "compress.svg"
    
    return None

def __main__():

    file_path = evaluate_file_path()
    if file_path == None:
        return -1 

    #Buscar apenas o nome do ficheiro para a descompressão
    #os.path.basename(your_path)

    GZip.compress(file_path, DataUnits.Byte)
    BZip2.compress(file_path, DataUnits.Byte)
    
    GZip.decompress(file_path)
    BZip2.decompress(file_path)

    return 1

__main__()
