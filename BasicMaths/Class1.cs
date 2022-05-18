using System;

namespace BasicMaths
{
    public class Matrix
    {

        float[][] matrix;
        int R, C;
        public Matrix( int r, int c)
        {

            R = r;
            C = c;
            this.matrix = new float[r][];
            for (int i=0;i<r;i++)
            {
                matrix[i] = new float[c];
                for (int j=0; j <c;j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        public void SetMatrix(float [][] arr)
        {
            for (int i=0;i<R;i++)
            {
                for (int j=0;j<C;j++ )
                {
                    matrix[i][j] = arr[i][j];
                }
            }
        }

        public void MultiplyBy(float n)
        {
            for(int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[i][j] *= n;
                }
            }
        }

        public Matrix MultiplyBy( Matrix m)
        {
            Matrix result = new Matrix(this.R, m.C);
            if ( m.R != this.C)
            {
                // implement try catc later
                Console.WriteLine("Error");
            }
            else
            {
       

                float sum = 0;
                for (int i=0;i<result.R;i++)
                {
                    for (int j=0;j<result.C;j++)
                    {

                        for (int k =0;k< this.C;k++  )
                        {
                            sum += (this.matrix[i][k] * m.matrix[k][j]) ;
                        }
                        result.matrix[i][j] = sum;
                        sum = 0;
                    }
                }
            }


            return result;
        }

        public void PrintMatrix()
        {
            for (int i=0;i<R;i++)
            {
                for (int k=0; k<C;k++)
                {
                    Console.Write( " "+matrix[i][k] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
