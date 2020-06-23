using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{
    static class SoporteParaConfiguracion
    {   
        public static void CrearArchivoDeConfiguracion(string Direccion)
        {
            BinaryWriter BinArch = new BinaryWriter(File.Open("destino.dat", FileMode.Create));
            BinArch.Write(Direccion);
            BinArch.Close();
        }
        public static string LeerConfiguracion()
        {
            BinaryReader BinArchR = new BinaryReader(File.Open("destino.dat", FileMode.Open));
            string Arch = BinArchR.ReadString();
            BinArchR.Close();
            return Arch;
        }
    }
    static class ConversorDeMorse
    {
        public static string MorseATexto(string FraseMorse)
        {
            string Texto = "";
            string[] Letras = FraseMorse.Split(' ');
            foreach (string Letrita in Letras)
            {
                switch (Letrita)
                {
                    case ".-":
                        Texto += 'a';
                        break;
                    case "-...":
                        Texto += 'b';
                        break;
                    case "-.-.":
                        Texto += 'c';
                        break;
                    case "-..":
                        Texto += 'd';
                        break;
                    case ".":
                        Texto += 'e';
                        break;
                    case "..-.":
                        Texto += 'f';
                        break;
                    case "--.":
                        Texto += 'g';
                        break;
                    case "....":
                        Texto += 'h';
                        break;
                    case "..":
                        Texto += 'i';
                        break;
                    case ".---":
                        Texto += 'j';
                        break;
                    case "-.-":
                        Texto += 'k';
                        break;
                    case ".-..":
                        Texto += 'l';
                        break;
                    case "--":
                        Texto += 'm';
                        break;
                    case "-.":
                        Texto += 'n';
                        break;
                    case "---":
                        Texto += 'o';
                        break;
                    case ".--.":
                        Texto += 'p';
                        break;
                    case "--.-":
                        Texto += 'q';
                        break;
                    case ".-.":
                        Texto += 'r';
                        break;
                    case "...":
                        Texto += 's';
                        break;
                    case "-":
                        Texto += 't';
                        break;
                    case "..-":
                        Texto += 'u';
                        break;
                    case "...-":
                        Texto += 'v';
                        break;
                    case ".--":
                        Texto += 'w';
                        break;
                    case "-..-":
                        Texto += 'x';
                        break;
                    case "-.--":
                        Texto += 'y';
                        break;
                    case "--..":
                        Texto += 'z';
                        break;
                    case ".----":
                        Texto += '1';
                        break;
                    case "..---":
                        Texto += '2';
                        break;
                    case "...--":
                        Texto += '3';
                        break;
                    case "....-":
                        Texto += '4';
                        break;
                    case ".....":
                        Texto += '5';
                        break;
                    case "-....":
                        Texto += '6';
                        break;
                    case "--...":
                        Texto += '7';
                        break;
                    case "---..":
                        Texto += '8';
                        break;
                    case "----.":
                        Texto += '9';
                        break;
                    case "-----":
                        Texto += '0';
                        break;
                    case "/":
                        Texto += ' ';
                        break;
                    default:
                        break;
                }
            }
            return Texto;
        }
        public static string TextoAMorse(string FraseCastellano)
        {
            string Morse = "";
            foreach (char Letra in FraseCastellano)
            {
                switch (Letra)
                {
                    case ' ':
                        Morse += "/ ";
                        break;
                    case 'a':
                        Morse += ".- ";
                        break;
                    case 'b':
                        Morse += "-... ";
                        break;
                    case 'c':
                        Morse += "-.-. ";
                        break;
                    case 'd':
                        Morse += "-.. ";
                        break;
                    case 'e':
                        Morse += ". ";
                        break;
                    case 'f':
                        Morse += "..-. ";
                        break;
                    case 'g':
                        Morse += "--. ";
                        break;
                    case 'h':
                        Morse += ".... ";
                        break;
                    case 'i':
                        Morse += ".. ";
                        break;
                    case 'j':
                        Morse += ".--- ";
                        break;
                    case 'k':
                        Morse += "-.- ";
                        break;
                    case 'l':
                        Morse += ".-.. ";
                        break;
                    case 'm':
                        Morse += "-- ";
                        break;
                    case 'n':
                        Morse += "-. ";
                        break;
                    case 'o':
                        Morse += "--- ";
                        break;
                    case 'p':
                        Morse += ".--. ";
                        break;
                    case 'q':
                        Morse += "--.- ";
                        break;
                    case 'r':
                        Morse += ".-. ";
                        break;
                    case 's':
                        Morse += "... ";
                        break;
                    case 't':
                        Morse += "- ";
                        break;
                    case 'u':
                        Morse += "..- ";
                        break;
                    case 'v':
                        Morse += "...- ";
                        break;
                    case 'w':
                        Morse += ".-- ";
                        break;
                    case 'x':
                        Morse += "-..- ";
                        break;
                    case 'y':
                        Morse += "-.-- ";
                        break;
                    case 'z':
                        Morse += "--.. ";
                        break;
                    case '1':
                        Morse += ".---- ";
                        break;
                    case '2':
                        Morse += "..--- ";
                        break;
                    case '3':
                        Morse += "...-- ";
                        break;
                    case '4':
                        Morse += "....- ";
                        break;
                    case '5':
                        Morse += "..... ";
                        break;
                    case '6':
                        Morse += "-.... ";
                        break;
                    case '7':
                        Morse += "--... ";
                        break;
                    case '8':
                        Morse += "---.. ";
                        break;
                    case '9':
                        Morse += "----. ";
                        break;
                    case '0':
                        Morse += "----- ";
                        break;
                    default:
                        break;
                }
            }
            GuardarArchivo(Morse);
            return Morse;
        }
        public static void GuardarArchivo(string TextoConvertido)
        {
            Directory.CreateDirectory(@"\Morse\");
            string archivo = @"\Morse\morse_[" + DateTime.Now.ToString("dd-MM-yy") + "].txt";
            StreamWriter A_morse = new StreamWriter(File.Open(archivo, FileMode.Create));
            A_morse.Write(TextoConvertido);
            A_morse.Close();
        }

        public static string LeerArchivo()
        {
            string archivo = @"\Morse\morse_[" + DateTime.Now.ToString("dd-MM-yy") + "].txt";
            StreamReader A_morse = new StreamReader(File.Open(archivo, FileMode.Open));
            string TextoTraducir = A_morse.ReadLine();
            A_morse.Close();
            return TextoTraducir;
        }
        public static void MoverArch(string Config)
        {
            Directory.CreateDirectory(Config);
            string Directorios = Directory.GetCurrentDirectory();
            string[] ArreArchDirectory = Directory.GetFiles(Directorios);
            foreach (string Archivo in ArreArchDirectory)
            {
                if (Archivo.Contains(".mp3") || Archivo.Contains(".txt"))
                {
                    string[] Cambio = Archivo.Split(@"\");
                    int Longitud = Cambio.Length;
                    Directory.Move(Archivo, Config + @"\" + Cambio[Longitud - 1]);
                }
            }
        }
        public static void MorseAudio()
        {
            string Texto = LeerArchivo();
            string Arch_Morse = @"\Audio_Morse.mp3";
            string conf = SoporteParaConfiguracion.LeerConfiguracion();
            string Path_Arch = conf + Arch_Morse;
            using (FileStream fs = File.OpenWrite(Path_Arch))
            {
                foreach (char Signo in Texto)
                {
                    if (Signo == '.')
                    {
                        byte[] punto = File.ReadAllBytes(conf + @"\punto.mp3");
                        fs.Write(punto, 0, punto.Length);
                        fs.Flush();
                    }
                    else if(Signo == '-')
                    {
                        byte[] guion = File.ReadAllBytes(conf + @"\raya.mp3");
                        fs.Write(guion, 0, guion.Length);
                        fs.Flush();
                    }
                }
                fs.Close();
            }
        }
    }
}