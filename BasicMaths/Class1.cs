    using System;

namespace BasicMaths
{



    public class constants
    {

       public const double E = 2.718281828459045;
    }
    public class Matrix
    {

        float[][] matrix;
        public int R, C;
        Random rand = new Random();
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
        public static Matrix fromarray( float []arr)
        {
            Matrix result = new Matrix(arr.Length, 1);
            for (int i=0;i<result.R;i++)
            {
                result.matrix[i][0] = arr[i];
            }

            return result;
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
        public void SetMatrix(float n)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[i][j] = n;
                }
            }
        }

        public void add(int n)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[i][j] +=n;
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

        public static Matrix MultiplyMatrices( Matrix m2, Matrix m)
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


        public static Matrix AddMatricies( Matrix m, Matrix m2)
        {

            Matrix result = new Matrix(m.R, m.C);

            for (int i=0;i<m.R;i++)
            {
                for (int j=0;j<m.C;j++)
                {
                    result.matrix[i][j] = m.matrix[i][j] + m2.matrix[i][j];
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

        public float[] Toarray(Matrix m)
        {
            float []arr = new float[ m.R * m.C];

            int k = 0;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                   arr[k]=  this.matrix[i][j];
                    k++;
                }

            }


            return arr;
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
        public void Randomize()
        {
            for (int i=0;i<R;i++)
            {
                for (int j =0; j<C;j++)
                {
                    this.matrix[i][j] = rand.Next();
                }
            }
        }

        public void Randomize( int min, int max)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    this.matrix[i][j] = rand.Next(min,max);
                }
            }
        } public void RandomizeF( int min, int max)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    this.matrix[i][j] = rand.Next(min,max)  *(float)rand.NextDouble();  
                }
            }
        }




        public static void map(Func<double, double> fn, Matrix m)
            {
                for (int i=0;i<m.R;i++)
            {
                for (int j=0;j<m.C;j++)
                {
                   m.matrix[i][j] =  (float) fn(m.matrix[i][j]);
                }
            }
                        
            }
    }
}
