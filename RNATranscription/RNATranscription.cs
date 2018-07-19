using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string newString = "";
            for(int i=0;i<nucleotide.Length;i++)
            {
                
                switch (nucleotide[i])
                {
                    case 'G': newString+='C';
                        break;
                    case 'C': newString += 'G';
                        break;
                    case 'T': newString += 'A';
                        break;
                    case 'A': newString += 'U';
                        break;
                }

            }
            return newString;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
