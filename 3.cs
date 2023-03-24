using System;

public class CaesarCipher {
    private int shift;

    public CaesarCipher(int shift) {
        this.shift = shift;
    }

    public string Encrypt(string plaintext) {
        char[] result = plaintext.ToCharArray();
        for (int i = 0; i < result.Length; i++) {
            char ch = result[i];
            ch = ShiftChar(ch, shift);
            result[i] = ch;
        }
        return new string(result);
    }

    public string Decrypt(string ciphertext) {
        char[] result = ciphertext.ToCharArray();
        for (int i = 0; i < result.Length; i++) {
            char ch = result[i];
            ch = ShiftChar(ch, -shift);
            result[i] = ch;
        }
        return new string(result);
    }

    private static char ShiftChar(char ch, int shift) {
        if (!char.IsLetter(ch)) {
            return ch;
        }
        char baseChar = char.IsUpper(ch) ? 'A' : 'a';
        int index = ch - baseChar;
        int shiftedIndex = (index + shift + 26) % 26;
        return (char)(baseChar + shiftedIndex);
    }
}


/* Демонстрация работы:

CaesarCipher cipher = new CaesarCipher(3);
string plaintext = "Hello, world!";
string ciphertext = cipher.Encrypt(plaintext);
string decryptedtext = cipher.Decrypt(ciphertext);
Console.WriteLine("Original text: " + plaintext);
Console.WriteLine("Encrypted text: " + ciphertext);
Console.WriteLine("Decrypted text: " + decryptedtext);

Результат:
Original text: Hello, world!
Encrypted text: Khoor, zruog!
Decrypted text: Hello, world!

Как можно видеть, при шифровании текста с помощью алгоритма шифра Цезаря с ключом 3, исходный текст "Hello, world!" был заменен на "Khoor, zruog!". При дешифровании этого зашифрованного текста с помощью того же самого ключа 3, получен был исходный текст "Hello, world!".
*/
