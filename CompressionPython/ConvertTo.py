from enum import Enum

class DataUnits(Enum):
    Byte = 0
    KiloByte = 1
    MegaByte = 2
    GigaByte = 3

def byte_to(value: int, data_unit: DataUnits) -> int:
    """Converts a given value to the given data unit"""
    if data_unit == DataUnits.Byte:
        return value
    elif data_unit == DataUnits.KiloByte:
        return value / 1024
    elif data_unit == DataUnits.MegaByte:
        return value / (1024 * 1024)
    elif data_unit == DataUnits.GigaByte:
        return value / (1024 * 1024 * 1024)
    return -1