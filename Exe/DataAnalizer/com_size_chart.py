import chartify
import pandas
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
    if os.path.isfile("log.txt"):
        return "log.txt"
    
    return None

#com_gzip_grande.svg.txt
def chart_generate(file_path):
    """Generates the chart using the data from file_path"""

    title = "Algorithm " + os.path.basename(file_path).split('_')[1]
    subtitle = "Compressed Size - " + os.path.basename(file_path).split('_')[2].split(".txt")[0]
    
    data = pandas.read_csv(file_path, sep=" ", header=None,
                        names=["Nivel", "Tamanho", "Tempo", "Lingua"])

    grouped_bar = (data.groupby(["Nivel", "Lingua"]) [["Tamanho"]].sum().reset_index())

    chart = chartify.Chart(y_axis_type="categorical", blank_labels=True)

    chart.plot.bar(data_frame=grouped_bar,
                categorical_columns=["Nivel", "Lingua"],
                numeric_column="Tamanho",
                color_column="Lingua")

    chart.plot.text(data_frame=grouped_bar,
                categorical_columns=["Nivel", "Lingua"],
                numeric_column="Tamanho",
                text_column="Tamanho",
                color_column="Lingua")

    chart.set_title(title)
    chart.set_subtitle(subtitle)
    chart.axes.set_yaxis_tick_orientation("horizontal")
    chart.axes.set_xaxis_label("Tamanho (KiloBytes)")
    chart.set_legend_location(None)
    chart.axes.hide_xaxis()
    chart.show()

def __main__():
    file_path = evaluate_file_path()
    if file_path == None:
        return -1
    
    chart_generate(file_path)


__main__()
