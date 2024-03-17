using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private const string contraseñaCorrecta = "123";
        private Label lblCurso;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblPassword;
        private Button loginButton;
        private TextBox passwordTextBox;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            lblCurso = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblPassword = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(121, 9);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(108, 15);
            lblCurso.TabIndex = 0;
            lblCurso.Text = "Estructura de datos";
            lblCurso.Click += lblCurso_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(100, 30);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(143, 15);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Autor: Nombre Completo";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(130, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(73, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Neiva Teams";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(74, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(150, 100);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(130, 150);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Ingresar";
            loginButton.BackColor = Color.White;
            loginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(327, 219);
            this.BackColor = Color.LightBlue;
            Controls.Add(lblCurso);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblPassword);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Acceso";
            ResumeLayout(false);
            PerformLayout();
        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == contraseñaCorrecta)
            {
                // Si la contraseña es correcta, abrir la ventana principal
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void lblCurso_Click(object sender, EventArgs e)
        {

        }
    }

    public class Trabajador
    {
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Genero { get; set; }
        public string Cargo { get; set; }
        public int DiasLaborados { get; set; }
        public DateTime FechaRegistro { get; set; }

        public decimal SalarioDiario { get; set; }
    }

    public class Nomina : Trabajador
    {
        private List<Trabajador> trabajadores = new List<Trabajador>();

        public void AgregarTrabajador(Trabajador trabajador)
        {
            trabajadores.Add(trabajador);
        }

        public decimal CalcularSalario(decimal diasLaborados, decimal salarioDia)
        {
            return diasLaborados * salarioDia;
        }
    }

    public partial class MainForm : Form
    {
        private Nomina nomina = new Nomina();

        private Label lblIdentificacion;
        private Label lblNombre;
        private Label lblGenero;
        private Label lblCargo;
        private Label lblSalarioDias;
        private Label lblDiasLaborados;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private ComboBox cmbGenero;
        private ComboBox cmbCargo;
        private TextBox txtSalarioDias;
        private NumericUpDown nudDiasLaborados;
        private Button btnGuardar;
        private Button btnCalcularNomina;
        private Button btnSalir;

        public MainForm()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            

            Text = "Formulario de Ingreso de Datos";
            ClientSize = new Size(700, 800);
            this.BackColor = Color.LightBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            lblIdentificacion = new Label();
            lblIdentificacion.Text = "Identificación:";
            lblIdentificacion.Location = new Point(10, 20);
            Controls.Add(lblIdentificacion);
            txtIdentificacion = new TextBox();
            txtIdentificacion.Location = new Point(150, 20);
            txtIdentificacion.Width = 200;
            Controls.Add(txtIdentificacion);

            // Implementa la inicialización de otros controles como nombre, género, cargo, etc.


            lblNombre = new Label(); // Etiqueta para el nombre
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new Point(10, 50);
            Controls.Add(lblNombre);

            txtNombre = new TextBox(); // Campo de texto para el nombre
            txtNombre.Location = new Point(150, 50);
            txtNombre.Width = 200;
            Controls.Add(txtNombre);

            lblCargo = new Label();
            lblCargo.Text = "Cargo:";
            lblCargo.Location = new Point(10, 110);
            Controls.Add(lblCargo);

            cmbCargo = new ComboBox();
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList; // Para que sea una lista desplegable
            cmbCargo.Location = new Point(150, 110);
            cmbCargo.Width = 150;
            // Agregar los cargos disponibles desde la variable previamente definida
            cmbCargo.Items.AddRange(new string[] { "Servicios Generales", "Administrativo", "Electricista", "Mecánico", "Soldador" });
            Controls.Add(cmbCargo);

            Label lblSalarioDias = new Label();
            lblSalarioDias.Text = "Salario Diario:";
            lblSalarioDias.Location = new Point(10, 140);
            Controls.Add(lblSalarioDias);

            txtSalarioDias = new TextBox();
            txtSalarioDias.Location = new Point(150, 140);
            txtSalarioDias.Width = 100;
            txtSalarioDias.Enabled = false; // Deshabilitar el cuadro de texto
            Controls.Add(txtSalarioDias);

            cmbCargo.SelectedIndexChanged += CmbCargo_SelectedIndexChanged;

            lblGenero = new Label();
            lblGenero.Text = "Género:";
            lblGenero.Location = new Point(10, 160);
            Controls.Add(lblGenero);

            cmbGenero = new ComboBox();
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList; // Para que sea una lista desplegable
            cmbGenero.Location = new Point(150, 170);
            cmbGenero.Width = 100;
            cmbGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
            Controls.Add(cmbGenero);

            lblDiasLaborados = new Label();
            lblDiasLaborados.Text = "Días Laborados:";
            lblDiasLaborados.Location = new Point(10, 170);
            Controls.Add(lblDiasLaborados);

            nudDiasLaborados = new NumericUpDown();
            nudDiasLaborados.Location = new Point(150, 200);
            nudDiasLaborados.Minimum = 0; // Definir el valor mínimo permitido
            nudDiasLaborados.Maximum = 31; // Definir el valor máximo permitido
            Controls.Add(nudDiasLaborados);

            btnGuardar = new Button();
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.BackColor = Color.White;
            btnGuardar.Location = new Point(10, 250);
            btnGuardar.Click += BtnGuardar_Click;
            Controls.Add(btnGuardar);
            btnCalcularNomina = new Button();
            btnCalcularNomina.Text = "Calcular Nómina";
            btnCalcularNomina.BackColor = Color.White;
            btnCalcularNomina.Location = new Point(140, 250);
            btnCalcularNomina.Click += BtnCalcularNomina_Click;
            Controls.Add(btnCalcularNomina);
            btnSalir = new Button();
            btnSalir.Text = "Salir de la Aplicación";
            btnSalir.BackColor = Color.White;
            btnSalir.Location = new Point(270, 250);
            btnSalir.Click += BtnSalir_Click;
            Controls.Add(btnSalir);
        }

        public void CmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCargo.SelectedItem != null)
            {
                // Obtener el salario correspondiente al cargo seleccionado
                string cargoSeleccionado = cmbCargo.SelectedItem.ToString();
                decimal salarioDiario = ObtenerSalarioDiario(cargoSeleccionado);

                // Mostrar el salario diario en el cuadro de texto
                txtSalarioDias.Text = salarioDiario.ToString("C"); // Formatear como moneda
            }
        }

        public decimal ObtenerSalarioDiario(string cargo)
        {
            // Implementa la lógica para obtener el salario diario según el cargo
            switch (cargo)
            {
                case "Servicios Generales":
                    return 40000m; // Salario diario para servicios generales
                case "Administrativo":
                    return 50000m; // Salario diario para administrativo
                case "Electricista":
                    return 60000m; // Salario diario para electricista
                case "Mecánico":
                    return 65000m; // Salario diario para mecánico
                case "Soldador":
                    return 70000m; // Salario diario para soldador
                default:
                    return 0m; // Valor predeterminado si el cargo no se reconoce
            }
        }

        
        public void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || cmbGenero.SelectedIndex == -1 || cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los días laborados sean un valor numérico positivo
            if (nudDiasLaborados.Value <= 0)
            {
                MessageBox.Show("Los días laborados deben ser un valor numérico positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nomina.Identificacion = txtIdentificacion.Text;
            nomina.NombreCompleto = txtNombre.Text;
            nomina.Genero = cmbGenero.SelectedItem.ToString();
            nomina.Cargo = cmbCargo.SelectedItem.ToString();
            nomina.DiasLaborados = (int)nudDiasLaborados.Value;
            nomina.SalarioDiario = ObtenerSalarioDiario(nomina.Cargo); // Guardar el salario diario en la clase Nomina
            nomina.FechaRegistro = DateTime.Now;

            // Crear un nuevo trabajador
            Trabajador nuevoTrabajador = new Trabajador
            {
               Identificacion = txtIdentificacion.Text,
               NombreCompleto = txtNombre.Text,
               Genero = cmbGenero.SelectedItem.ToString(),
               Cargo = cmbCargo.SelectedItem.ToString(),
               DiasLaborados = (int)nudDiasLaborados.Value,
               FechaRegistro = DateTime.Now
            };

            // Agregar el trabajador a la lista de trabajadores en la clase Nomina
            nomina.AgregarTrabajador(nuevoTrabajador);

            // Limpiar los campos después de guardar
            LimpiarCampos();
        }

        public void BtnCalcularNomina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtIdentificacion.Text) || cmbGenero.SelectedItem == null || cmbCargo.SelectedItem == null || nudDiasLaborados.Value == 0)
            {
                MessageBox.Show("Por favor, ingrese todos los datos necesarios antes de calcular la nómina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los datos del trabajador y el salario diario según el cargo
            string nombre = txtNombre.Text;
            string identificacion = txtIdentificacion.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            string cargo = cmbCargo.SelectedItem.ToString();
            int diasLaborados = (int)nudDiasLaborados.Value;
            decimal salarioDiario = ObtenerSalarioDiario(cargo); // Aquí debes implementar la lógica para obtener el salario diario según el cargo seleccionado
            string fecha = nomina.FechaRegistro.ToString();


            // Calcular el salario mensual
            decimal salarioMensual = nomina.CalcularSalario(diasLaborados, salarioDiario);

            // Obtener la fecha actual
             

            // Mostrar el mensaje con la información de la nómina
            string mensaje = $"El señor {nombre} identificado con la cédula de ciudadanía número {identificacion} de género {genero} está contratado ejerciendo el cargo de {cargo}. Tiene una asignación diaria de su salario de {salarioDiario:C}, en el transcurso del mes trabajó {diasLaborados} días para un total devengado de {salarioMensual:C}. a la fecha actual {fecha}";
            MessageBox.Show(mensaje, "Cálculo de Nómina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void BtnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir?";
            DialogResult result = MessageBox.Show(mensaje, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                
                Application.Exit();
            }

        }

        public void LimpiarCampos()
        {
            // Implementa la lógica para limpiar todos los campos del formulario
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            cmbGenero.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;
            nudDiasLaborados.Value = 0;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}