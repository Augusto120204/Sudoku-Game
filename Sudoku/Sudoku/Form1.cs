using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public static int Dimension = 9;

        public static Boolean resolver(int[,] tablero)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (tablero[i, j] != 0)
                        continue;
                    else
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (esPosibleInsertar(tablero, i, j, k))
                            {
                                tablero[i, j] = k;
                                Boolean b = resolver(tablero);

                                if (b)
                                    return true;

                                tablero[i, j] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean esPosibleInsertar(int[,] tablero, int i, int j, int valor)
        {
            for (int a = 0; a < Dimension; a++)
            {
                if (a != i && tablero[a, j] == valor)
                    return false;
            }
            for (int a = 0; a < Dimension; a++)
            {
                if (a != j && tablero[i, a] == valor)
                    return false;
            }
            int y = (i / 3) * 3;
            int x = (j / 3) * 3;

            for (int a = 0; a < Dimension / 3; a++)
            {
                for (int b = 0; b < Dimension / 3; b++)
                {
                    if (a != i && b != j && tablero[y + a, x + b] == valor)
                        return false;
                }
            }
            return true;
        }

        static int[,] GenerarJuegoAleatorio(string dificultad)
        {
            Random r = new Random();
            int[,] tablero = new int[,]
            {
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
            };

            int numero = r.Next(1, 10);
            int fila = r.Next(0, 9);
            int columna = r.Next(0, 9);

            tablero[fila, columna] = numero;

            resolver(tablero);

            HashSet<(int, int)> casillasUtilizadas = new HashSet<(int, int)>();

            if (dificultad == "Facil")
            {
                for (int i = 0; i < 50; i++)
                {
                    (int fila, int columna) casilla;
                    do
                    {
                        casilla.fila = r.Next(0, 9);
                        casilla.columna = r.Next(0, 9);
                    } while (casillasUtilizadas.Contains(casilla));

                    casillasUtilizadas.Add(casilla);
                    tablero[casilla.fila, casilla.columna] = 0;
                }
            }
            else if (dificultad == "Medio")
            {
                for (int i = 0; i < 60; i++)
                {
                    (int fila, int columna) casilla;
                    do
                    {
                        casilla.fila = r.Next(0, 9);
                        casilla.columna = r.Next(0, 9);
                    } while (casillasUtilizadas.Contains(casilla));

                    casillasUtilizadas.Add(casilla);
                    tablero[casilla.fila, casilla.columna] = 0;
                }
            }
            else if (dificultad == "Dificil")
            {
                for (int i = 0; i < 70; i++)
                {
                    (int fila, int columna) casilla;
                    do
                    {
                        casilla.fila = r.Next(0, 9);
                        casilla.columna = r.Next(0, 9);
                    } while (casillasUtilizadas.Contains(casilla));

                    casillasUtilizadas.Add(casilla);
                    tablero[casilla.fila, casilla.columna] = 0;
                }
            }

            return tablero;
        }

        public Form1()
        {
            InitializeComponent();
            resolverJuego.Enabled = false;
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    RichTextBox richTextBox = tableLayoutPanel1.GetControlFromPosition(j, i) as RichTextBox;

                    if (richTextBox != null)
                    {
                        richTextBox.KeyPress += richTextBox_KeyPress;
                    }
                }
            }
        }

        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (richTextBox.Text.Length > 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    RichTextBox richTextBox = control as RichTextBox;
                    if (richTextBox != null)
                    {
                        richTextBox.Text = "";
                        richTextBox.ReadOnly = false;
                        richTextBox.ForeColor = Color.Black;
                    }
                }
            }

            string dificultad = cmbDificultad.Text;
            int[,] tablero = GenerarJuegoAleatorio(dificultad);

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);

                    if (tablero[i, j] != 0)
                    {
                        RichTextBox richTextBox = control as RichTextBox;
                        if (richTextBox != null)
                        {
                            richTextBox.Text = tablero[i, j].ToString();
                            richTextBox.ReadOnly = true;
                            richTextBox.ForeColor = Color.DarkBlue;
                        }
                    }
                    else
                    {
                        control.Text = "";
                    }
                }
            }
            resolverJuego.Enabled = true;
        }

        private void richTextBox80_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComprobarSolucion_Click(object sender, EventArgs e)
        {
            int[,] tablero = new int[,]
            {
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
            };

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    RichTextBox richTextBox = control as RichTextBox;

                    if (richTextBox != null)
                    {
                        if (richTextBox.Text.Length > 0)
                        {
                            tablero[i, j] = int.Parse(richTextBox.Text);
                        }
                    }
                }
            }

            if (resolver(tablero))
            {
                bool solucionCorrecta = true;
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < Dimension; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                        RichTextBox richTextBox = control as RichTextBox;

                        if (richTextBox != null)
                        {
                            if (richTextBox.Text.Length > 0)
                            {
                                if (tablero[i, j] != int.Parse(richTextBox.Text))
                                {
                                    solucionCorrecta = false;
                                }
                            }
                            else
                            {
                                solucionCorrecta = false;
                            }
                        }
                    }
                }
                if (!solucionCorrecta)
                {
                    MessageBox.Show("Solución incorrecta", "Comprobar Solucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Solución correcta!", "Comprobar Solucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Solución incorrecta", "Comprobar Solucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    RichTextBox richTextBox = control as RichTextBox;
                    if (richTextBox != null)
                    {
                        richTextBox.Text = "";
                        richTextBox.ReadOnly = false;
                        richTextBox.ForeColor = Color.Black;
                    }
                }
            }
            resolverJuego.Enabled = false;
        }

        private void CondicionInicial_Click(object sender, EventArgs e)
        {
            int[,] tablero = new int[,]
            {
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
            };

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    RichTextBox richTextBox = control as RichTextBox;

                    if (richTextBox != null)
                    {
                        if (richTextBox.Text.Length > 0)
                        {
                            int numero = int.Parse(richTextBox.Text);
                            if (esPosibleInsertar(tablero, i, j, numero))
                            {
                                tablero[i, j] = int.Parse(richTextBox.Text);
                            }
                            else
                            {
                                richTextBox.Text = "";
                                tablero[i, j] = 0;
                                MessageBox.Show("Este tablero no se puede resolver", "Condicion Inicial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }

            if (resolver(tablero))
            {
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < Dimension; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                        RichTextBox richTextBox = control as RichTextBox;
                        if (richTextBox != null && richTextBox.Text != "")
                        {
                            richTextBox.ReadOnly = true;
                            richTextBox.ForeColor = Color.DarkBlue;
                        }
                    }
                }
                MessageBox.Show("¡Condicion establecida!", "Condicion Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resolverJuego.Enabled = true;
            }
        }

        private void resolverJuego_Click(object sender, EventArgs e)
        {
            int[,] tablero = new int[,]
            {
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},

                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
                {0,0,0,  0,0,0,   0,0,0},
            };

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    RichTextBox richTextBox = control as RichTextBox;

                    if (richTextBox != null)
                    {
                        if (richTextBox.Text.Length > 0 && richTextBox.ReadOnly == true)
                        {
                            tablero[i, j] = int.Parse(richTextBox.Text);
                        }
                    }
                }
            }

            if (resolver(tablero))
            {
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < Dimension; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                        RichTextBox richTextBox = control as RichTextBox;
                        if (richTextBox != null && richTextBox.ReadOnly == false)
                        {
                            richTextBox.Text = tablero[i, j].ToString();
                            richTextBox.ReadOnly = true;
                        }
                    }
                }
            }
        }
    }
}