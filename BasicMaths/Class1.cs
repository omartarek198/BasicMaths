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

        public static Matrix MultiplyMatrices( Matrix m, Matrix m2)
        {

            Matrix result = new Matrix(m2.R, m.C);
            if ( m.R != m2.C)
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

                        for (int k =0;k< m2.C;k++  )
                        {
                            sum += (m2.matrix[i][k] * m.matrix[k][j]) ;
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

        public void Transpose()
        {
            Matrix temp = new Matrix(C, R);

            for (int i=0;i<R;i++)
            {
                for (int j = 0; j<C;j++)
                {
                    temp.matrix[j][i] = this.matrix[i][j];
                }

            }

            int swap = R;
            R = C;
            C = swap;
            this.matrix = new float[R][];
            for (int i = 0; i < R; i++)

            {
                matrix[i] = new float[C];
                for (int j = 0; j < C; j++)
                {
                      this.matrix[i][j] = temp.matrix[i][j];
                }

            }


        }

        public static void map(Func<float, float> fn, Matrix m)
            {
                for (int i=0;i<m.R;i++)
            {
                for (int j=0;j<m.C;j++)
                {
                   m.matrix[i][j] = fn(m.matrix[i][j]);
                }
            }
                        
            }
    }
}
