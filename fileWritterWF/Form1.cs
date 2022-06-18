namespace fileWritterWF
{
    public partial class Form1 : Form
    {
        List<Pelicula> peliculas { get; set; }
        string path = @"C:\Users\pc\Desktop\UCE 2022 C2\Optimizacion de algoritmos\archivo.txt";

        public Form1()
        {
            InitializeComponent();
            peliculas = new List<Pelicula>();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            var peli = new Pelicula();
            peli.titulo = titulo.Text ?? "N/A";
            peli.duracion = duracion.Text ?? "N/A";
            peli.clasificacion = clasificacion.Text ?? "N/A";
            peli.escrito = escritor.Text ?? "N/A";
            peli.director = director.Text ?? "N/A";
            peli.genero = genero.Text ?? "N/A";
            peli.productora = productora.Text ?? "N/A";

            peliculas.Add(peli);
            
            
            escribirArchivo(peli);
            showDataFromFile();

        }

        private void escribirArchivo(Pelicula pelicula) 
        {

            using (StreamWriter sw = File.CreateText(path))
            {

                foreach (var pel in peliculas)
                {
                    sw.WriteLine("___________");
                    sw.WriteLine("Titulo: " + pel.titulo);

                    sw.WriteLine("Director: " + pel.director);
                    sw.WriteLine("Escritor:" + pel.titulo);

                    sw.WriteLine("Genero: " + pel.genero);

                    sw.WriteLine("Clasificacion: " + pel.clasificacion);

                    sw.WriteLine("Duracion: " + pel.duracion);

                    sw.WriteLine("Productora: " + pel.productora);

                    sw.WriteLine("___________");

                }

            }
        }

        private void showDataFromFile() 
        {
            using (StreamReader sr = File.OpenText(path))
            {
                listBox1.Items.Clear();
                int contador = 0;
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (contador == 8) {  contador = -1; }
                    listBox1.Items.Add(linea);

                   contador++;
                }
            }
        }

       

       
    }
}