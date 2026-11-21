using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Green
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            answer = new int[r];
            for (int i = 0; i < r; i++)
            {
                int minindex = 0;
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] < matrix[i, minindex])
                    {
                        minindex = j;
                    }
                }
                answer[i] = minindex;
            }
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            for (int i = 0; i < r; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < c; ++j)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;

                    }
                }
                int max = matrix[i, maxIndex];
                if (max ==0) continue;
                for (int j = 0; j < maxIndex; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = (int)Math.Floor((double)matrix[i, j] / max);
                    }
                }

            }
            // end

        }
        public void Task3(int[,] matrix, int k)
        {

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            if (k < 0 || k >= c || r != c) return;
            int maxIndex = 0;
            for (int i = 0; i < r; i++)
            {
                if (matrix[i, i] > matrix[maxIndex, maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex == k) return;
            for (int i = 0; i < r; i++)
            {
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, maxIndex];
                matrix[i, maxIndex] = temp;
            }

            // end

        }
        public void Task4(int[,] matrix)
        {

            // code here
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            if (r != c) return;

            int diagpos = 0;
            for (int i = 0; i < r; i++)
            {
                if (matrix[i,i] > matrix[diagpos, diagpos])
                {
                    diagpos = i;
                }
            }
            for (int j = 0; j < r; j++)
            {
                int temp = matrix[diagpos, j];
                matrix[diagpos, j] = matrix[j, diagpos];
                matrix[j, diagpos] = temp;

            }
            // end

        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            if (matrix == null) return new int[0, 0];
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            if (r == 0 || c == 0) return matrix;
            int maxsum = -1;
            int rd = 0;
            
            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] > 0)
                        sum += matrix[i, j];
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                    rd = i;
                }
            
            }
            int[,] newmatrix = new int[r - 1, c];
            int newrow = 0;
            for (int i = 0; i < r; i++)
            {
                if (i == rd) continue;
                for (int j = 0; j < c; j++)
                {
                    newmatrix[newrow, j] = matrix[i, j];
                    
                }
                newrow++;
            } 
            answer = newmatrix;
            // end

            return answer;
        }
        public void Task6(int[,] matrix)
        {

            // code here
            if (matrix == null) return;
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            if ( r == 0 || c == 0 ) return;
            int minnegcount = c + 1;
            int minnegrow = 0;
            int maxnegcount = -1;
            int maxnegrow = 0;
            for (int i = 0; i < r; i++)
            {
                int count = 0;
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
                if (count < minnegcount)
                {
                    minnegcount = count;
                    minnegrow = i;
                }
                if (count > maxnegcount)
                {
                    maxnegcount = count;
                    maxnegrow = i;
                }
            }
                if (minnegrow != maxnegrow)
                {
                    for (int j = 0; j < c; j++)
                    {
                        int temp = matrix[minnegrow , j];
                        matrix[minnegrow, j] = matrix[maxnegrow, j];
                        matrix[maxnegrow, j ] = temp;
                    }
                }
            
            // end

        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here
            if (matrix == null) return new int[0,0];
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            if (c == 0 || r == 0 || array == null || array.Length != r) return matrix;
            int minval = matrix[0,0];
            int mincol= 0;
            for (int i = 0; i < r; i++)
            {
               
               
                
                    for (int j = 0; j < c; j++)
                    {
                        if (matrix[i, j] < minval)
                        {
                            minval = matrix[i, j];
                            mincol = j;
                        }
                    }
                
            }
            int[,] newmatrix = new int[r, c + 1];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j <= mincol; j++)
                {
                    newmatrix[i,j] = matrix[i, j]; 
                }
                newmatrix[i, mincol + 1] = array[i]; 

                for (int j = mincol + 1; j < c; j++) 
                {
                    newmatrix[i, j + 1] = matrix[i, j]; 
                }
            }
            answer  = newmatrix;
            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here

            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task12(int[][] array)
        {

            // code here

            // end

        }
    }
}
