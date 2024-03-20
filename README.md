# Caesar Cipher Encryption

## Overview
This C# program implements a simple Caesar cipher encryption algorithm. A Caesar cipher is a substitution cipher where each letter in the plaintext is shifted a certain number of places down or up the alphabet.

## Usage
1. Run the program.
2. Enter the secret message you want to encrypt when prompted.
3. The program will encrypt the message using a Caesar cipher with a fixed shift of 3.
4. The encrypted message will be displayed as the output.

## Algorithm
- The program defines an array representing the English alphabet.
- It prompts the user to input a secret message.
- The message is converted into an array of characters.
- The program encrypts each letter of the message by shifting it three positions to the right in the alphabet (with wrapping around the end of the alphabet).
- The encrypted message is displayed as output.

## Example
If the user inputs "hello", the program will output "khoor", as each letter is shifted three positions to the right.

## Author
This program was created by [Your Name] and is provided under the [MIT License](LICENSE).
