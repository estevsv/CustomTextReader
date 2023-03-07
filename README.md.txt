## Custom Text Reader
This is a simple program written in C# that reads a text file and separates the sentences based on the language rules of English, Portuguese, Spanish and German.

# Usage
To use this program, follow these steps:

Clone this repository or download the code files.
Build and run the program in Visual Studio or any other C# IDE. (you can just take the .exe in Reader 2.0>bin>Debug )
When prompted, enter text you want to analyze in input space.
Select the language rule you want to use for separating the sentences.
Select the sorting order for the sentences - by sequence or by length (min or max) of characters.
The program will then display the separated sentences and the average number of characters in text.
Filter a word usind the field "Word Filter"

# Supported Languages
This program currently supports the following languages for sentence separation:

English
Portuguese
Spanish
German

# Sorting Options
The program allows you to sort the separated sentences by two options:

Sequence: The order of the sentences will be maintained as in the original text.
Length: The sentences will be sorted by length of characters, either in ascending or descending order.

# Example Usage
Suppose you have the following text:

"This is a sample text. It contains multiple sentences. Can you separate them?"

You can use this program to separate the sentences as follows:

Enter text you want to analyze in input space
Select the language rule for English.
Select the sorting order by length, either "min" or "max".
The program will display the following output:

Separated Sentences:
Number of characters		Sentence
31					It contains multiple sentences.
22					This is a sample text.
22					Can you separate them?

Average characters: 25
