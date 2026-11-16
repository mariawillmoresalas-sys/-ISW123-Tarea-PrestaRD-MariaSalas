namespace PrestaRD
{
    public partial class Form1 : Form
    {

        private readonly List<Prestamo> prestamos = new List<Prestamo>();
        private Prestamo? ultimo;

        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.AddRange(new object[] { "Personal", "Vehículo", "Hipotecario" });
            cmbTipo.SelectedIndex = 0;
        }

        private decimal TasaAnual(string tipo)
        {
            return tipo switch
            {
                "Personal" => 0.18m,
                "Vehículo" => 0.12m,
                "Hipotecario" => 0.09m,
                _ => -1m
            };
        }

        private decimal CalcularCuota(decimal monto, decimal tasaAnual, int plazo)
        {
            double i = (double)tasaAnual / 12;                 // tasa mensual
            double factor = Math.Pow(1 + i, -plazo);           // (1 + i) elevado a -n
            double cuota = (double)monto * i / (1 - factor);
            return Math.Round((decimal)cuota, 2);


        }




        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            lstSalida.Items.Clear();

            string cliente = txtCliente.Text.Trim();
            int edad = (int)nudEdad.Value;
            decimal ingreso = nudIngresos.Value;
            decimal monto = nudMonto.Value;
            int plazo = (int)nudPlazo.Value;

            if (cliente == "")
            {
                MessageBox.Show("Escribe el nombre del cliente.");
                return;
            }
            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.");
                return;
            }

            lstSalida.Items.Add($"Cliente: {cliente}");
            lstSalida.Items.Add($"Monto: RD$ {monto:N2} a {plazo} meses");


            string tipo = cmbTipo.Text;
            decimal tasaAnual = TasaAnual(tipo);
            lstSalida.Items.Add($"Tipo: {tipo} · tasa anual {tasaAnual * 100:0}%");

            decimal cuota = CalcularCuota(monto, tasaAnual, plazo);
            lstSalida.Items.Add($"Cuota mensual: RD$ {cuota:N2}");

            bool tieneAtrasos = chkAtrasos.Checked;
            int edadFinal = edad + plazo / 12;

            bool capacidadOk = cuota <= ingreso * 0.35m;
            bool edadOk = edadFinal <= 75;
            bool aprobado = capacidadOk && edadOk && !tieneAtrasos;

           
            lstSalida.Items.Add($"Edad al terminar: {edadFinal} {(edadOk ? "✔" : "✘ pasa de 75")}");
            lstSalida.Items.Add($"Historial: {(tieneAtrasos ? "✘ tiene atrasos" : "✔ sin atrasos")}");

            lblResultado.Text = aprobado ? "APROBADO" : "RECHAZADO";
            lblResultado.ForeColor = aprobado ? Color.Green : Color.Red;

            ultimo = new Prestamo
            {
                Cliente = cliente,
                Tipo = tipo,
                Monto = monto,
                Plazo = plazo,
                Cuota = cuota,
                Aprobado = aprobado
            };


           

            decimal relacion = ingreso > 0 ? (cuota / ingreso) : 0;
            lstSalida.Items.Add($"Cuota / ingreso: {relacion:P1} {(capacidadOk ? "✔" : "✘ pasa de 35%")}");



        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            lstSalida.Items.Clear();
            decimal monto = nudMonto.Value;
            int plazo = (int)nudPlazo.Value;
            decimal tasaAnual = TasaAnual(cmbTipo.Text);
            decimal tasaMensual = tasaAnual / 12;
            decimal cuota = CalcularCuota(monto, tasaAnual, plazo);
            decimal saldo = monto;

            lstSalida.Items.Add($"{"Mes",4} {"Cuota",12} {"Interés",12} {"Capital",12} {"Saldo",14}");
            for (int mes = 1; mes <= plazo; mes++)
            {
                decimal interes = Math.Round(saldo * tasaMensual, 2);
                decimal capital = cuota - interes;
                saldo -= capital;
                lstSalida.Items.Add($"{mes,4} {cuota,12:N2} {interes,12:N2} {capital,12:N2} {saldo,14:N2}");
            }
        }

        private void btnSimularPago_Click(object sender, EventArgs e)
        {
            lstSalida.Items.Clear();
            decimal saldo = nudMonto.Value;
            decimal tasaMensual = TasaAnual(cmbTipo.Text) / 12;
            decimal pago = nudPago.Value;
            int meses = 0;

            while (saldo > 0)
            {
                saldo += Math.Round(saldo * tasaMensual, 2);   // interés del mes
                saldo -= pago;
                meses++;
            }

            lstSalida.Items.Add($"Pagando RD$ {pago:N2} al mes, termina en {meses} meses");
            lstSalida.Items.Add($"En el último pago le sobran RD$ {-saldo:N2}");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (ultimo == null) { MessageBox.Show("Primero evalúa un préstamo."); return; }
            prestamos.Add(ultimo);
            ultimo = null;                       // para no registrarlo dos veces
            lstPrestamos.Items.Clear();
            foreach (Prestamo p in prestamos) lstPrestamos.Items.Add(p);
        }

        private void btnCartera_Click(object sender, EventArgs e)
        {
            var porTipo = new Dictionary<string, decimal>();

            foreach (Prestamo p in prestamos)
            {
                if (!p.Aprobado) continue;

                if (porTipo.ContainsKey(p.Tipo))
                    porTipo[p.Tipo] += p.Monto;
                else
                    porTipo[p.Tipo] = p.Monto;
            }

            lstSalida.Items.Clear();
            lstSalida.Items.Add("Cartera aprobada por tipo:");
            foreach (var par in porTipo)
                lstSalida.Items.Add($"   {par.Key,-12} RD$ {par.Value,14:N2}");
        }
    }
}
