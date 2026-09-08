/*******************************************************************
*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 08 / 09 / 2026
 * Autores do Projeto: Isabela Rangel
 * Autores do Projeto: André Luiz Alves Nunes
 *
 * Turma: 3J
 * Atividade Proposta em aula
 * Observação: Projeto 3 Bimestre
 *
 *
 * ******************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto4
{
    public partial class Form1 : Form
    {
        // =====================================================================
        // 1) VÉRTICES (Passo 1 do enunciado)
        // =====================================================================
        private int[] verticesX = { -80, 80, 0, -129, 129, -129, 129, 0, 0, -80, 80, 0 };
        private int[] verticesY = { -46, -46, 92, 75, 75, -75, -75, 149, -149, -46, -46, 92 };

        // =====================================================================
        // 2) FACES (Passo 3 do enunciado)
        // =====================================================================
        private int[,] faces = new int[10, 3]
        {
            {0, 1, 2}, // Face 1  - central
            {0, 3, 2}, // Face 2  - médio esquerdo
            {1, 4, 2}, // Face 3  - médio direito
            {0, 1, 8}, // Face 4  - médio inferior
            {0, 3, 5}, // Face 5  - externo esquerdo
            {1, 4, 6}, // Face 6  - externo direito
            {3, 2, 7}, // Face 7  - externo superior esquerdo
            {4, 2, 7}, // Face 8  - externo superior direito
            {0, 5, 8}, // Face 9  - externo inferior esquerdo
            {1, 6, 8}, // Face 10 - externo inferior direito
        };

        // Cor atual de cada uma das 10 faces (mosaico)
        private Color[] coresFaces = new Color[10];

        // Cor selecionada no mosaico
        private Color corSelecionada = Color.FromArgb(255, 255, 255);
        private bool corFoiEscolhida = false;

        // Valores controlados pelas TrackBars (Passo 4 do enunciado)
        private int deslocX = 0;
        private int deslocY = 0;
        private int escalaPercentual = 100; // 100 = escala normal (100%)

        // Centro fixo onde a figura é desenhada, antes de aplicar as transformações
        private const int CENTRO_X = 300;
        private const int CENTRO_Y = 280;

        public Form1()
        {
            InitializeComponent();
        }

        // =====================================================================
        // PRIMITIVAS DE DESENHO
        // =====================================================================
        public Color cor(int R, int G, int B)
        {
            Color cor = new Color();
            cor = Color.FromArgb(R, G, B);
            return cor;
        }

        public Pen criarCaneta(int R, int G, int B)
        {
            Pen caneta = new Pen(cor(R, G, B), 2);
            return caneta;
        }

        public void desenhaLinha(Graphics e, Pen caneta, int x0, int y0, int x1, int y1)
        {
            e.DrawLine(caneta, x0, y0, x1, y1);
        }

        public void desenhaContorno(PaintEventArgs e, Pen caneta, Point[] pontos)
        {
            e.Graphics.DrawPolygon(caneta, pontos);
        }

        public void preencheArea(PaintEventArgs e, SolidBrush fundo, Point[] pontos)
        {
            e.Graphics.FillPolygon(fundo, pontos);
        }

        public SolidBrush criarPincel(Color cor)
        {
            SolidBrush fundo = new SolidBrush(cor);
            return fundo;
        }

        public Point[] criarPoligono(int[] x, int[] y)
        {
            int tamanho = x.Length;
            Point[] pontos = new Point[tamanho];

            for (int i = 0; i < tamanho; i++)
                pontos[i] = new Point(x[i], y[i]);

            return pontos;
        }

        public void definirCorSelecionada(int R, int G, int B)
        {
            corSelecionada = cor(R, G, B);
            corFoiEscolhida = true;
        }

        // =====================================================================
        // CARREGAMENTO DO FORMULÁRIO
        // =====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                coresFaces[i] = cor(255, 255, 255);

            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
        }

        // =====================================================================
        // MOSAICO DE CORES — botões criados no Designer, cada um com seu
        // próprio método de clique
        // =====================================================================
        private void btnCor1_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(255, 0, 0); // vermelho
        }

        private void btnCor2_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(0, 0, 255); // azul
        }

        private void btnCor3_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(0, 255, 0); // verde
        }

        private void btnCor4_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(255, 255, 0); // amarelo
        }

        private void btnCor5_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(255, 165, 0); // laranja
        }

        private void btnCor6_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(128, 0, 128); // roxo
        }

        private void btnCor7_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(0, 255, 255); // ciano
        }

        private void btnCor8_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(139, 69, 19); // marrom
        }

        private void btnCor9_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(0, 0, 0); // preto
        }

        private void btnCor10_Click(object sender, EventArgs e)
        {
            definirCorSelecionada(255, 255, 255); // branco
        }

        // =====================================================================
        // EVENTOS DOS TRACKBARS
        // =====================================================================
        private void AtualizarTranslacaoX(object sender, EventArgs e)
        {
            deslocX = barraTranslacaoX.Value;
            labelX.Text = "Translação X: " + deslocX;
            Invalidate();
        }

        private void AtualizarTranslacaoY(object sender, EventArgs e)
        {
            deslocY = barraTranslacaoY.Value;
            labelY.Text = "Translação Y: " + deslocY;
            Invalidate();
        }

        private void AtualizarEscala(object sender, EventArgs e)
        {
            escalaPercentual = trackEscala.Value;
            labelEscala.Text = "Escala: " + escalaPercentual + "%";
            Invalidate();
        }

        // =====================================================================
        // TRANSFORMA UM VÉRTICE DO MODELO PARA COORDENADA DE TELA.
        // =====================================================================
        private Point TransformarParaTela(int modeloX, int modeloY)
        {
            double escala = escalaPercentual / 100.0;

            int telaX = CENTRO_X + deslocX + (int)(modeloX * escala);
            int telaY = CENTRO_Y - deslocY + (int)(modeloY * escala);

            return new Point(telaX, telaY);
        }

        // Monta os arrays x[] e y[] de uma face já transformados para tela,
        // para poder usar a primitiva criarPoligono(x, y)
        private Point[] PontosDaFace(int indiceFace)
        {
            int[] fx = new int[3];
            int[] fy = new int[3];

            for (int j = 0; j < 3; j++)
            {
                int indiceVertice = faces[indiceFace, j];
                Point p = TransformarParaTela(verticesX[indiceVertice], verticesY[indiceVertice]);
                fx[j] = p.X;
                fy[j] = p.Y;
            }

            return criarPoligono(fx, fy);
        }

        // =====================================================================
        // DESENHO DO ICOSAEDRO (evento Paint do formulário)
        // =====================================================================
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = criarCaneta(0, 0, 0);

            for (int i = 0; i < 10; i++)
            {
                Point[] pontos = PontosDaFace(i);

                // Preenchimento da face
                SolidBrush pincel = criarPincel(coresFaces[i]);
                preencheArea(e, pincel, pontos);

                // Contorno da face, aresta por aresta, usando a primitiva desenhaLinha
                for (int j = 0; j < pontos.Length; j++)
                {
                    Point atual = pontos[j];
                    Point proximo = pontos[(j + 1) % pontos.Length];

                    desenhaLinha(e.Graphics, caneta, atual.X, atual.Y, proximo.X, proximo.Y);
                }
            }
        }

        // =====================================================================
        // CLIQUE DO MOUSE
        // =====================================================================
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (!corFoiEscolhida)
                return;

            for (int i = 0; i < 10; i++)
            {
                Point[] pontos = PontosDaFace(i);

                if (PontoDentroDoPoligono(x, y, pontos))
                {
                    coresFaces[i] = corSelecionada;
                    Invalidate();
                    return;
                }
            }
        }

        // =====================================================================
        // ALGORITMO "PONTO DENTRO / PONTO FORA"
        // =====================================================================
        private bool PontoDentroDoPoligono(int pontoClicadoX, int pontoClicadoY, Point[] pontos)
        {
            int contador = 0;

            for (int i = 0; i < pontos.Length; i++)
            {
                Point verticeA = pontos[i];
                Point verticeB = pontos[(i + 1) % pontos.Length];

                bool cruzaFaixaY = (verticeA.Y > pontoClicadoY) != (verticeB.Y > pontoClicadoY);

                if (cruzaFaixaY)
                {
                    double inclinacaoAresta = (double)(verticeB.Y - verticeA.Y) / (verticeB.X - verticeA.X);
                    double interceptoAresta = verticeA.Y - inclinacaoAresta * verticeA.X;

                    double xCruzamento;

                    if (verticeB.X == verticeA.X)
                    {
                        xCruzamento = verticeA.X;
                    }
                    else
                    {
                        xCruzamento = (pontoClicadoY - interceptoAresta) / inclinacaoAresta;
                    }

                    if (pontoClicadoX < xCruzamento)
                        contador++;
                }
            }

            return (contador % 2) == 1;
        }
    }
}