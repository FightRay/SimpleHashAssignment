using System;

namespace DevAssignmentRay
{
    /*
     * @author Ray
     * Created for the SpringboardVR assignment
     */
    public class Hasher
    {
        /*
         * Hash function
         * A simple hash function that takes an input string
         * and outputs a fixed-length 32-byte (256-bit) hash value
         * 
         * string @input : The input string
        */
        public static string Hash(string input)
        {
            string hash = string.Empty;
            
            // Length of the final hash
            int hashlen = 32; // 256-bit

            // Total of ascii decimals in the input string
            int total = 0;

            // Calculate the total of the decimal values of each ascii character and store it
            for (int x = 0; x < input.Length; x++)
            {
                total += (int)input[x];
            }

            // Generate 4 styles of hash values as parts of the final hash
            for (int t = 0; t < (hashlen / 8); t++)
            {
                long key = 0;
                switch (t)
                {
                    case 0:
                        key = long.MaxValue / total;
                        break;
                    case 1:
                        key = long.MaxValue - total;
                        break;
                    case 2:
                        key = int.MaxValue / total;
                        break;
                    case 3:
                        key = int.MaxValue - total;
                        break;
                }

                // Convert the 64-bit integer to a hex string and add to the final hash
                hash += key.ToString("X16");
            }

            return hash;
        }
    }
}
