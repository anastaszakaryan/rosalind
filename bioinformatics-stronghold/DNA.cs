using System;

namespace bioinformatics_stronghold
{
    internal class DNA
    {
        public static string CountingDNANucleotides(string s)
        {
            var countA = 0;
            var countC = 0;
            var countG = 0;
            var countT = 0;

            for (var i = 0; i < s.Length; i++)
            {
                switch (s.Substring(i, 1))
                {
                    case "A":
                        countA += 1;
                        break;
                    case "C":
                        countC += 1;
                        break;
                    case "G":
                        countG += 1;
                        break;
                    case "T":
                        countT += 1;
                        break;
                }
            }

            return $"{countA} {countC} {countG} {countT}";
        }

        /* public static void Main(string[] args)
        {
            Console.WriteLine(CountingDNANucleotides(
                "GGCCCCGTATTGGGTAATTCCTCGTAGGGTTGGAGATACCTCTATTATCGGATCGAATGCTGGGCTCTATGTTGCCCCGCATCCGGATTGGTTGAGGAAAAATTATATAGCGGTCGGCGTAATAGACCTACTAGGATATGAGGCACGGAATCATGGTTGTATGGATCGGTTTTAACTGGCGCTGCCAGCGAGACGATCCAGTCGCTGATTTACCACATGAAGAGCGCCTAAGTTCACTCCGCACTGTAAATCTCACCATTGTCGGCATTGCCCCATATACGGGCCAGTAGCGAGCTCCGAACAATGTCATTGACGATCATAGGGCAATTGGACACTCATGGCGGGGGGGCGGGCCTATTATGTGAACTAAGTGGTTCATCCACCGTAGGGGCTGTTAGCTACTCAGGACTGCCGCTCGTTAACCGTGCCGTGTTCGCCGCGGTAGATCATGTCCCCGTGGTAAGAACTCGATCCTATAACATGCCGTGAGTGAAAGCTACATTCTACCAAATGGGAGTCCGCACTGAAAGGAATGTTAACGAGTTACAAACCAAGAAAATCGGGAGGATTATCTTACCGCTAGAGTGTGCAAGTCAATAGCTTTTAATGAAGAACAAACCGACGGATTCCGGGAGAGTCGCCACCGAGATTTGCCAACTCACTCTGCTCTCGCTTGATCTTTTGCTGTCATTAGTCTGCCCGTTCGATGTCTAAAGCGTGACTTAGGACGTTCTTTATGGGTGGCCCACAACTTTTTCACATATTTTATAATAATTTGAGGGCTTCTGTATCAGAACGCTCGCGTCGAAATCTCGGTAATAAGCTCATGCCAACATTGGCCATCAGAGATCTAGCGGTGGCGTGCAGGGCCGGTTGCTGCCCATTCATCA"));
        }
        */
    }
}