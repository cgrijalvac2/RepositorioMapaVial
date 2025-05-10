using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //PRUEBA 
        bool direccionCarro1Derecha = true;
        bool direccionCarro2Izquierda = true;
        bool direccionCarro3Arriba = true;
        bool direccionCarro4Abajo = true;
        bool direccionCarro5Arriba = true;
        bool direccionCarro6Derecha = true;
        bool direccionCarro7Izquierda = true;

        //SEMAFORO
        private int estado = 0; //0: ROJO, 1: VERDE, 2: AMARILLO
        private int segundosRestantes = 5;

        //CARRO VISUAL
        bool moverGrupo1 = false; // pictureBox3 y pictureBox4
        bool moverGrupo2 = false; // pictureBox1 y pictureBox2

        //SIMULACION
        private Interseccion interseccionCentral;
        private ListaHistorial historialTrafico;
        private ListaRutas rutas;
        private int direccionActual = 0; // 0=Norte, 1=Oeste, 2=Sur, 3=Este

        // 0=Norte, 1=Oeste, 2=Sur, 3=Este
        private System.Windows.Forms.Timer timerSimulacion; // Timer para automatizació
        private Random rnd = new Random(); // A nivel de clase

        //carros 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        List<PictureBox> carros = new List<PictureBox>();

        public Form1()
        {
            ListBox lstMovimientosPestaña3 = new ListBox
            {
                Name = "lstMovimientosPestaña3",
                Location = new Point(20, 20),
                Size = new Size(400, 200),
                Parent = tabPage3 // Asignar a la pestaña 3
            };

            InitializeComponent();

            //carros

            historialTrafico = new ListaHistorial();
            rutas = new ListaRutas();
            mapaPanel.Paint += MapaPanel_Paint;

            // Configurar el temporizador
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += timer1_Tick;

            InicializarRedVial();
            CambiarColorSemaforo();
            CambiarColorSemaforo2();
            CambiarColorSemaforo3();
            CambiarColorSemaforo4();
            CambiarColorSemaforo5();
            CambiarColorSemaforo6();
            CambiarColorSemaforo7();

            lblTemporizador.Text = segundosRestantes.ToString();

            timerSimulacion = new System.Windows.Forms.Timer();
            timerSimulacion.Interval = 1000; // 1 segundo entre movimientos
            timerSimulacion.Tick += TimerSimulacion_Tick;


        }

        private void InicializarRedVial()
        {
            var infoCentral = new InformacionInterseccion(1, "Centro", new Point(300, 200));
            interseccionCentral = new Interseccion(infoCentral);
            ConectarIntersecciones();
            rutas.AgregarInterseccion(interseccionCentral);
            mapaPanel.Invalidate();
            ActualizarUI();
            string estadoInicial = "Rojo";
            interseccionCentral.Informacion.EstadoSemaforo = estadoInicial;

            if (interseccionCentral.Este != null)
                interseccionCentral.Este.Informacion.EstadoSemaforo = estadoInicial;

            if (interseccionCentral.Oeste != null)
            {
                interseccionCentral.Oeste.Informacion.EstadoSemaforo = estadoInicial;

                if (interseccionCentral.Oeste.Oeste != null)
                    interseccionCentral.Oeste.Oeste.Informacion.EstadoSemaforo = estadoInicial;
            }
        }

        private void CambiarColorSemaforo()
        {

            // Apagar todas las luces
            panelRojo.BackColor = Color.Gray;
            panelAmarillo.BackColor = Color.Gray;
            panelVerde.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo.BackColor = Color.Red;
                    break;
                case 1:
                    panelVerde.BackColor = Color.Green;
                    break;
                case 2:
                    panelAmarillo.BackColor = Color.Yellow;
                    break;
            }

        }

        private void CambiarColorSemaforo2()
        {
            // Apagar todas las luces
            panelRojo2.BackColor = Color.Gray;
            panelAmarillo2.BackColor = Color.Gray;
            panelVerde2.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo2.BackColor = Color.Red;
                    break;
                case 1:
                    panelVerde2.BackColor = Color.Green;
                    break;
                case 2:
                    panelAmarillo2.BackColor = Color.Yellow;
                    break;
            }
        }

        private void CambiarColorSemaforo3()
        {
            // Apagar todas las luces
            panelRojo3.BackColor = Color.Gray;
            panelAmarillo3.BackColor = Color.Gray;
            panelVerde3.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo3.BackColor = Color.Green;
                    break;
                case 1:
                    panelVerde3.BackColor = Color.Red;
                    break;
                case 2:
                    panelAmarillo3.BackColor = Color.Yellow;
                    break;
            }
        }
        private void CambiarColorSemaforo4()
        {
            // Apagar todas las luces
            panelRojo4.BackColor = Color.Gray;
            panelAmarillo4.BackColor = Color.Gray;
            panelVerde4.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo4.BackColor = Color.Green;
                    break;
                case 1:
                    panelVerde4.BackColor = Color.Red;
                    break;
                case 2:
                    panelAmarillo4.BackColor = Color.Yellow;
                    break;
            }
        }

        private void CambiarColorSemaforo5()
        {
            // Apagar todas las luces
            panelRojo5.BackColor = Color.Gray;
            panelAmarillo5.BackColor = Color.Gray;
            panelVerde5.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo5.BackColor = Color.Red;
                    break;
                case 1:
                    panelVerde5.BackColor = Color.Green;
                    break;
                case 2:
                    panelAmarillo5.BackColor = Color.Yellow;
                    break;
            }
        }

        private void CambiarColorSemaforo6()
        {
            // Apagar todas las luces
            panelRojo6.BackColor = Color.Gray;
            panelAmarillo6.BackColor = Color.Gray;
            panelVerde6.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo6.BackColor = Color.Green;
                    break;
                case 1:
                    panelVerde6.BackColor = Color.Red;
                    break;
                case 2:
                    panelAmarillo6.BackColor = Color.Yellow;
                    break;
            }
        }

        private void CambiarColorSemaforo7()
        {
            // Apagar todas las luces
            panelRojo7.BackColor = Color.Gray;
            panelAmarillo7.BackColor = Color.Gray;
            panelVerde7.BackColor = Color.Gray;

            // Encender la correspondiente
            switch (estado)
            {
                case 0:
                    panelRojo7.BackColor = Color.Green;
                    break;
                case 1:
                    panelVerde7.BackColor = Color.Red;
                    break;
                case 2:
                    panelAmarillo7.BackColor = Color.Yellow;
                    break;
            }
        }
        private void ConectarIntersecciones()
        {
            // Intersección Central (existente)
            var infoCentral = new InformacionInterseccion(1, "Centro", new Point(400, 200));
            interseccionCentral = new Interseccion(infoCentral);

            // Norte (existente)
            var norte = new Interseccion(new InformacionInterseccion(2, "Norte", new Point(400, 100)));
            interseccionCentral.Norte = norte;
            norte.Sur = interseccionCentral;
            rutas.AgregarInterseccion(norte);

            // Sur (existente)
            var sur = new Interseccion(new InformacionInterseccion(3, "Sur", new Point(400, 300)));
            interseccionCentral.Sur = sur;
            sur.Norte = interseccionCentral;
            rutas.AgregarInterseccion(sur);

            // Este (existente)
            var este = new Interseccion(new InformacionInterseccion(4, "Este", new Point(500, 200)));
            interseccionCentral.Este = este;
            este.Oeste = interseccionCentral;
            rutas.AgregarInterseccion(este);

            // Oeste-Centro (antes "Oeste")
            var oesteCentro = new Interseccion(new InformacionInterseccion(5, "Oeste-Centro", new Point(300, 200)));
            interseccionCentral.Oeste = oesteCentro;
            oesteCentro.Este = interseccionCentral;
            rutas.AgregarInterseccion(oesteCentro);

            // Conectando Oeste-Centro (Norte, Sur, Oeste)
            var oesteNorte = new Interseccion(new InformacionInterseccion(6, "Oeste-Norte", new Point(300, 100)));
            oesteCentro.Norte = oesteNorte;
            oesteNorte.Sur = oesteCentro;
            rutas.AgregarInterseccion(oesteNorte);

            var oesteSur = new Interseccion(new InformacionInterseccion(7, "Oeste-Sur", new Point(300, 300)));
            oesteCentro.Sur = oesteSur;
            oesteSur.Norte = oesteCentro;
            rutas.AgregarInterseccion(oesteSur);

            var oesteOeste = new Interseccion(new InformacionInterseccion(8, "Oeste-Oeste", new Point(200, 200)));
            oesteCentro.Oeste = oesteOeste;
            oesteOeste.Este = oesteCentro;
            rutas.AgregarInterseccion(oesteOeste);

            //  conectamos Oeste-Oeste con sus propias intersecciones (Norte, Sur, Oeste)
            var oesteOesteNorte = new Interseccion(new InformacionInterseccion(9, "Oeste-Oeste-Norte", new Point(200, 100)));
            oesteOeste.Norte = oesteOesteNorte;
            oesteOesteNorte.Sur = oesteOeste;
            rutas.AgregarInterseccion(oesteOesteNorte);

            var oesteOesteSur = new Interseccion(new InformacionInterseccion(10, "Oeste-Oeste-Sur", new Point(200, 300)));
            oesteOeste.Sur = oesteOesteSur;
            oesteOesteSur.Norte = oesteOeste;
            rutas.AgregarInterseccion(oesteOesteSur);

            var oesteOesteOeste = new Interseccion(new InformacionInterseccion(11, "Oeste-Oeste-Oeste", new Point(100, 200)));
            oesteOeste.Oeste = oesteOesteOeste;
            oesteOesteOeste.Este = oesteOeste;
            rutas.AgregarInterseccion(oesteOesteOeste);
        }

        private void MapaPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DibujarRedVial(g, interseccionCentral, new HashSet<int>());
        }

        private void DibujarRedVial(Graphics g, Interseccion interseccion, HashSet<int> dibujados)
        {
            if (dibujados.Contains(interseccion.Informacion.Id)) return;
            dibujados.Add(interseccion.Informacion.Id);

            Color colorSemaforo;

            // Caso 1: Si es una intersección Norte o Sur (por nombre)
            if (interseccion.Informacion.Nombre.EndsWith("Norte") ||
                interseccion.Informacion.Nombre.EndsWith("Sur"))
            {
                colorSemaforo = Color.Blue; // 🔵 Color para Norte/Sur
            }
            // Caso 2: Si es Central, Este, Oeste-Centro, Oeste-Oeste u Oeste-Oeste-Oeste (por ID o nombre)
            else if (interseccion.Informacion.Id == 1 ||  // Central
                     interseccion.Informacion.Id == 4 ||  // Este
                     interseccion.Informacion.Id == 5 ||  // Oeste-Centro
                     interseccion.Informacion.Id == 8 ||  // Oeste-Oeste
                     interseccion.Informacion.Id == 11)   // Oeste-Oeste-Oeste
            {
                // Usa el estado del txtSemaforo
                colorSemaforo = txtSemaforo.Text == "Verde" ? Color.Green :
                               txtSemaforo.Text == "Rojo" ? Color.Red : Color.Yellow;
            }
            // Caso 3: Otras intersecciones (estado normal)
            else
            {
                colorSemaforo = interseccion.Informacion.EstadoSemaforo == "Verde" ? Color.Green :
                               interseccion.Informacion.EstadoSemaforo == "Rojo" ? Color.Red : Color.Yellow;
            }

            // Dibujar la intersección (círculo)
            g.FillEllipse(new SolidBrush(colorSemaforo),
                         interseccion.Informacion.Ubicacion.X - 15,
                         interseccion.Informacion.Ubicacion.Y - 15, 30, 30);

            // Dibujar el nombre
            g.DrawString(interseccion.Informacion.Nombre, Font, Brushes.Black,
                        interseccion.Informacion.Ubicacion.X - 15,
                        interseccion.Informacion.Ubicacion.Y - 30);

            // Dibujar conexiones (Norte, Sur, Este, Oeste)
            DibujarConexion(g, interseccion, interseccion.Norte, "N");
            DibujarConexion(g, interseccion, interseccion.Sur, "S");
            DibujarConexion(g, interseccion, interseccion.Este, "E");
            DibujarConexion(g, interseccion, interseccion.Oeste, "O");

            // Dibujar recursivamente
            if (interseccion.Norte != null) DibujarRedVial(g, interseccion.Norte, dibujados);
            if (interseccion.Sur != null) DibujarRedVial(g, interseccion.Sur, dibujados);
            if (interseccion.Este != null) DibujarRedVial(g, interseccion.Este, dibujados);
            if (interseccion.Oeste != null) DibujarRedVial(g, interseccion.Oeste, dibujados);
        }

        private void DibujarConexion(Graphics g, Interseccion origen, Interseccion destino, string direccion)
        {
            if (destino == null) return;

            Pen pen = new Pen(Color.Blue, 2);
            g.DrawLine(pen, origen.Informacion.Ubicacion, destino.Informacion.Ubicacion);

            PointF puntoMedio = new PointF(
                (origen.Informacion.Ubicacion.X + destino.Informacion.Ubicacion.X) / 2,
                (origen.Informacion.Ubicacion.Y + destino.Informacion.Ubicacion.Y) / 2);

            g.DrawString(direccion, Font, Brushes.Black, puntoMedio);
        }
        private void TimerSimulacion_Tick(object sender, EventArgs e)
        {
            // Solo rotar en la central (las demás se sincronizan)
            RotarSemaforo(interseccionCentral);

            // Resto del código (mover vehículos, actualizar UI, etc.)
            if (interseccionCentral.Informacion.EstadoSemaforo == "Verde")
                MoverVehiculos(interseccionCentral);

            ActualizarUI();

            if (interseccionCentral.Informacion.VehiculosEnEspera <= 0)
                DetenerSimulacion();
        }


        private void btnSimular_Click(object sender, EventArgs e)
        {
            timerSimulacion.Start();
            btnSimular.Enabled = false; // Desactivar botón mientras simula
            btnDetenerSimulacion.Enabled = true;

            // Cambiar semáforos y mover vehículos solo cuando está en verde
            if (interseccionCentral.Informacion.EstadoSemaforo == "Verde")
            {
                MoverVehiculos(interseccionCentral);
            }

            // Rotar el estado del semáforo
            RotarSemaforo(interseccionCentral);

            // Calcular y mostrar congestión
            var congestion = CalcularCongestionTotal();
            historialTrafico.AgregarRegistro(DateTime.Now, congestion.total, congestion.interseccionMasCongestionada);

            // Actualizar UI
            mapaPanel.Invalidate();
            ActualizarUI();
        }


        private void RotarSemaforo(Interseccion interseccion)
        {
            // Solo rotar si es la intersección central (las demás se sincronizarán)
            if (interseccion.Informacion.Id == 1) // ID 1 = Central
            {
                // Cambiar estado de la central
                interseccion.Informacion.EstadoSemaforo =
                    interseccion.Informacion.EstadoSemaforo == "Verde" ? "Amarillo" :
                    interseccion.Informacion.EstadoSemaforo == "Amarillo" ? "Rojo" : "Verde";

                // Sincronizar las demás intersecciones
                if (interseccion.Este != null)
                    interseccion.Este.Informacion.EstadoSemaforo = interseccion.Informacion.EstadoSemaforo;

                if (interseccion.Oeste != null && interseccion.Oeste.Informacion.Id == 5) // Oeste-Centro (ID 5)
                {
                    interseccion.Oeste.Informacion.EstadoSemaforo = interseccion.Informacion.EstadoSemaforo;

                    // Sincronizar Oeste-Oeste (ID 8)
                    if (interseccion.Oeste.Oeste != null)
                        interseccion.Oeste.Oeste.Informacion.EstadoSemaforo = interseccion.Informacion.EstadoSemaforo;
                }
            }
        }

        private void MoverVehiculos(Interseccion interseccion)
        {

            // Verificación EXTRA de vehículos disponibles
            if (interseccion.Informacion.VehiculosEnEspera <= 0)
            {
                timerSimulacion.Stop();
                MessageBox.Show("¡No hay más vehículos por mover!");
                return;
            }

            // Cálculo SEGURO de cantidad a mover 
            int maxPosible = Math.Min(7, interseccion.Informacion.VehiculosEnEspera);
            int vehiculosAMover = rnd.Next(1, maxPosible + 1);

            // Asignación con doble verificación
            vehiculosAMover = Math.Min(vehiculosAMover, interseccion.Informacion.VehiculosEnEspera);
            interseccion.Informacion.VehiculosEnEspera -= vehiculosAMover;

            // Elige dirección inicial aleatoria
            int direccion = rnd.Next(4);
            bool movimientoExitoso = false;
            int intentos = 0;

            while (!movimientoExitoso && intentos < 4)
            {
                switch (direccion)
                {
                    case 0 when interseccion.Norte != null:
                        interseccion.Norte.Informacion.VehiculosEnEspera += vehiculosAMover;
                        interseccion.Informacion.VehiculosHaciaNorte += vehiculosAMover;

                        int tiempoNorte = CalcularTiempoEstimado(
                            interseccion.Informacion.Nombre,
                            interseccion.Norte.Informacion.Nombre,
                            interseccion.Informacion.VehiculosEnEspera
                        );

                        string mensajeNorte = $"{DateTime.Now:T} - {interseccion.Informacion.Nombre} -> Norte: {vehiculosAMover} | Tiempo: {tiempoNorte} min";
                        lstMovimientos.Items.Add(mensajeNorte);
                        LstReporteFlujo.Items.Add(mensajeNorte);
                        movimientoExitoso = true;
                        break;

                    case 1 when interseccion.Oeste != null:
                        interseccion.Oeste.Informacion.VehiculosEnEspera += vehiculosAMover;
                        interseccion.Informacion.VehiculosHaciaOeste += vehiculosAMover;

                        int tiempoOeste = CalcularTiempoEstimado(
                            interseccion.Informacion.Nombre,
                            interseccion.Oeste.Informacion.Nombre,
                            interseccion.Informacion.VehiculosEnEspera
                        );

                        string mensajeOeste = $"{DateTime.Now:T} - {interseccion.Informacion.Nombre} -> Oeste: {vehiculosAMover} | Tiempo: {tiempoOeste} min";
                        lstMovimientos.Items.Add(mensajeOeste);
                        LstReporteFlujo.Items.Add(mensajeOeste);
                        movimientoExitoso = true;
                        break;

                    case 2 when interseccion.Sur != null:
                        interseccion.Sur.Informacion.VehiculosEnEspera += vehiculosAMover;
                        interseccion.Informacion.VehiculosHaciaSur += vehiculosAMover;

                        int tiempoSur = CalcularTiempoEstimado(
                            interseccion.Informacion.Nombre,
                            interseccion.Sur.Informacion.Nombre,
                            interseccion.Informacion.VehiculosEnEspera
                        );

                        string mensajeSur = $"{DateTime.Now:T} - {interseccion.Informacion.Nombre} -> Sur: {vehiculosAMover} | Tiempo: {tiempoSur} min";
                        lstMovimientos.Items.Add(mensajeSur);
                        LstReporteFlujo.Items.Add(mensajeSur);
                        movimientoExitoso = true;
                        break;

                    case 3 when interseccion.Este != null:
                        interseccion.Este.Informacion.VehiculosEnEspera += vehiculosAMover;
                        interseccion.Informacion.VehiculosHaciaEste += vehiculosAMover;

                        int tiempoEste = CalcularTiempoEstimado(
                            interseccion.Informacion.Nombre,
                            interseccion.Este.Informacion.Nombre,
                            interseccion.Informacion.VehiculosEnEspera
                        );

                        string mensajeEste = $"{DateTime.Now:T} - {interseccion.Informacion.Nombre} -> Este: {vehiculosAMover} | Tiempo: {tiempoEste} min";
                        lstMovimientos.Items.Add(mensajeEste);
                        LstReporteFlujo.Items.Add(mensajeEste);
                        movimientoExitoso = true;
                        break;
                }

                if (!movimientoExitoso)
                {
                    direccion = (direccion + 1) % 4;
                    intentos++;
                }

            }


            if (lstMovimientos.Items.Count > 50) lstMovimientos.Items.RemoveAt(0);
            if (LstReporteFlujo.Items.Count > 50) LstReporteFlujo.Items.RemoveAt(0);

            if (interseccionCentral.Informacion.VehiculosEnEspera <= 0)
            {
                timerSimulacion.Stop();
                btnSimular.Enabled = true;
                btnDetenerSimulacion.Enabled = false;
            }
        }

        private (int total, string interseccionMasCongestionada) CalcularCongestionTotal()
        {
            var visitados = new HashSet<int>();
            int total = 0;
            string interseccionMasCongestionada = "";
            int maxCongestion = 0;

            CalcularCongestionRecursivo(interseccionCentral, visitados, ref total, ref interseccionMasCongestionada, ref maxCongestion);

            return (total, interseccionMasCongestionada);
        }

        private void CalcularCongestionRecursivo(Interseccion interseccion, HashSet<int> visitados,
                                               ref int total, ref string interseccionMasCongestionada, ref int maxCongestion)
        {
            if (visitados.Contains(interseccion.Informacion.Id)) return;
            visitados.Add(interseccion.Informacion.Id);

            total += interseccion.Informacion.VehiculosEnEspera;

            if (interseccion.Informacion.VehiculosEnEspera > maxCongestion)
            {
                maxCongestion = interseccion.Informacion.VehiculosEnEspera;
                interseccionMasCongestionada = interseccion.Informacion.Nombre;
            }

            if (interseccion.Norte != null) CalcularCongestionRecursivo(interseccion.Norte, visitados, ref total, ref interseccionMasCongestionada, ref maxCongestion);
            if (interseccion.Sur != null) CalcularCongestionRecursivo(interseccion.Sur, visitados, ref total, ref interseccionMasCongestionada, ref maxCongestion);
            if (interseccion.Este != null) CalcularCongestionRecursivo(interseccion.Este, visitados, ref total, ref interseccionMasCongestionada, ref maxCongestion);
            if (interseccion.Oeste != null) CalcularCongestionRecursivo(interseccion.Oeste, visitados, ref total, ref interseccionMasCongestionada, ref maxCongestion);
        }

        private void ActualizarUI()
        {

            if (interseccionCentral != null)
            {
                // Actualizar valores básicos
                txtVehiculos.Text = interseccionCentral.Informacion.VehiculosEnEspera.ToString();
                txtSemaforo.Text = interseccionCentral.Informacion.EstadoSemaforo;

                // Actualizar resumen de movimientos (ORIGINAL en pestaña 1)
                string resumen = $"Centro: {interseccionCentral.Informacion.VehiculosEnEspera}  \n" +
                               $"Norte: {interseccionCentral.Informacion.VehiculosHaciaNorte}  \n" +
                               $"Oeste: {interseccionCentral.Informacion.VehiculosHaciaOeste}  \n" +
                               $"Sur: {interseccionCentral.Informacion.VehiculosHaciaSur}  \n" +
                               $"Este: {interseccionCentral.Informacion.VehiculosHaciaEste} ";

                txtResumenMovimientos.Text = resumen;

                // COPIAR al TextBox de la pestaña 3 
                txtResumenFlujo.Text = resumen;

                // Forzar repintado del mapa
                mapaPanel.Invalidate();
            }
        }

        private string ObtenerNombreDireccion(int direccion) => direccion switch
        {
            0 => "Norte",
            1 => "Oeste",
            2 => "Sur",
            3 => "Este",
            _ => "Desconocida"
        };

        private void btnAgregarVehiculos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarVehiculos.Text, out int cantidad) && cantidad > 0)
            {
                // Reinicia contadores si es nueva simulación
                if (interseccionCentral.Informacion.VehiculosEnEspera == 0)
                {
                    interseccionCentral.Informacion.VehiculosHaciaNorte = 0;
                    interseccionCentral.Informacion.VehiculosHaciaOeste = 0;
                    interseccionCentral.Informacion.VehiculosHaciaSur = 0;
                    interseccionCentral.Informacion.VehiculosHaciaEste = 0;
                }

                interseccionCentral.Informacion.VehiculosEnEspera += cantidad;
                ActualizarUI();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;

            lblTemporizador.Text = segundosRestantes.ToString();

            if (segundosRestantes == 0)
            {
                estado = (estado + 1) % 3; // Cambia color del semáforo
                CambiarColorSemaforo();
                CambiarColorSemaforo2();
                CambiarColorSemaforo3();
                CambiarColorSemaforo4();
                CambiarColorSemaforo5();
                CambiarColorSemaforo6();
                CambiarColorSemaforo7();

                if (estado == 0) // Verde para semáforo 1 y 2
                {
                    moverGrupo1 = true;
                    moverGrupo2 = false;
                }
                else if (estado == 1) // Verde para semáforo 3 y 4
                {
                    moverGrupo1 = false;
                    moverGrupo2 = true;
                }
                else // Rojo para todos
                {
                    moverGrupo1 = false;
                    moverGrupo2 = false;
                }
                CambiarColorSemaforo();
                CambiarColorSemaforo2();
                CambiarColorSemaforo3();
                CambiarColorSemaforo4();

                segundosRestantes = 5; // Reinicia el contador
            }
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Stop(); // Detiene el movimiento de carros
                btnIniciar.Text = "Iniciar";

                // segundosRestantes = 5;

                CambiarColorSemaforo();
                CambiarColorSemaforo2();
                CambiarColorSemaforo3();
                CambiarColorSemaforo4();
                CambiarColorSemaforo5();
                CambiarColorSemaforo6();
                CambiarColorSemaforo7();


                lblTemporizador.Text = segundosRestantes.ToString();
            }
            else
            {
                timer1.Start();
                timer2.Start();
                btnIniciar.Text = "Detener";

                if (carros.Count == 0)
                    InicializarCarros();

                InicializarTimer();

                //Activar movimiento según el estado actual del semáforo inmediatamente
                if (estado == 0) // Verde para semáforo 1 y 2
                {
                    moverGrupo1 = true;
                    moverGrupo2 = false;
                }
                else if (estado == 1) // Verde para semáforo 3 y 4
                {
                    moverGrupo1 = false;
                    moverGrupo2 = true;
                }
                else // Rojo para todos
                {
                    moverGrupo1 = false;
                    moverGrupo2 = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DetenerSimulacion()
        {
            interseccionCentral.Informacion.VehiculosEnEspera = 0;

            timerSimulacion.Stop();
            btnSimular.Enabled = true;
            btnDetenerSimulacion.Enabled = false;

            txtVehiculos.Text = "0";
            ActualizarUI();

            MessageBox.Show("¡Todos los vehículos han sido movidos!",
                          "Simulación completada",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);


        }

        //CARROS 
        private void InicializarCarros()
        {
            for (int i = 0; i < 2; i++)
            {

                PictureBox c = new PictureBox
                {
                    Image = Properties.Resources.carroAmarillo, // Usa una imagen en Resources
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(50, 30),
                    Location = new Point(i * 10, 10 + i * 10)
                };
                carros.Add(c);
                this.Controls.Add(c);
            }
        }

        private void InicializarTimer()
        {
            timer2.Interval = 50;
            timer2.Tick += MoverCarros;
            timer2.Start();
        }

        private void MoverCarros(object sender, EventArgs e)
        {

            // Márgenes para pictureBox3 y pictureBox4
            int margenDerecho = 180;
            int margenIzquierdo = 560;

            // Márgenes individuales para pictureBox6 y pictureBox7
            int margenDerecho6 = 430;
            int margenIzquierdo6 = 300;

            int margenDerecho7 = 430;
            int margenIzquierdo7 = 300;

            // Márgenes para pictureBox1 y pictureBox2
            int margenVertical = 100;

            if (moverGrupo1)
            {
                // pictureBox3 
                if (direccionCarro1Derecha)
                {
                    pictureBox3.Left += 7;
                    if (pictureBox3.Right >= this.ClientSize.Width - margenDerecho)
                        direccionCarro1Derecha = false;
                }
                else
                {
                    pictureBox3.Left -= 7;
                    if (pictureBox3.Left <= margenIzquierdo)
                        direccionCarro1Derecha = true;
                }

                // pictureBox6 
                if (direccionCarro6Derecha)
                {
                    pictureBox6.Left += 7;
                    if (pictureBox6.Right >= this.ClientSize.Width - margenDerecho6)
                        direccionCarro6Derecha = false;
                }
                else
                {
                    pictureBox6.Left -= 7;
                    if (pictureBox6.Left <= margenIzquierdo6)
                        direccionCarro6Derecha = true;
                }

                // pictureBox4 
                if (direccionCarro2Izquierda)
                {
                    pictureBox4.Left -= 7;
                    if (pictureBox4.Left <= margenIzquierdo)
                        direccionCarro2Izquierda = false;
                }
                else
                {
                    pictureBox4.Left += 7;
                    if (pictureBox4.Right >= this.ClientSize.Width - margenDerecho)
                        direccionCarro2Izquierda = true;
                }
                //PictureBox7
                if (direccionCarro7Izquierda)
                {
                    pictureBox7.Left -= 7;
                    if (pictureBox7.Left <= margenIzquierdo7)
                        direccionCarro7Izquierda = false;
                }
                else
                {
                    pictureBox7.Left += 7;
                    if (pictureBox7.Right >= this.ClientSize.Width - margenDerecho7)
                        direccionCarro7Izquierda = true;
                }
            }

            if (moverGrupo2)
            {
                // pictureBox1 (vertical hacia arriba o abajo)
                if (direccionCarro3Arriba)
                {
                    pictureBox1.Top -= 7;
                    if (pictureBox1.Top <= margenVertical)
                        direccionCarro3Arriba = false;
                }
                else
                {
                    pictureBox1.Top += 7;
                    if (pictureBox1.Bottom >= this.ClientSize.Height - margenVertical)
                        direccionCarro3Arriba = true;
                }

                // pictureBox5 
                if (direccionCarro5Arriba)
                {
                    pictureBox5.Top -= 7;
                    if (pictureBox5.Top <= margenVertical)
                        direccionCarro5Arriba = false;
                }
                else
                {
                    pictureBox5.Top += 7;
                    if (pictureBox5.Bottom >= this.ClientSize.Height - margenVertical)
                        direccionCarro5Arriba = true;
                }

                // pictureBox2 
                if (direccionCarro4Abajo)
                {
                    pictureBox2.Top += 7;
                    if (pictureBox2.Bottom >= this.ClientSize.Height - margenVertical)
                        direccionCarro4Abajo = false;
                }
                else
                {
                    pictureBox2.Top -= 7;
                    if (pictureBox2.Top <= margenVertical)
                        direccionCarro4Abajo = true;
                }
            }

        }

        private void MovimientoTimer_Tick(object sender, EventArgs e)
        {
            // Mover pictureBox1 a la izquierda
            if (pictureBox1.Left > 0)
                pictureBox1.Left -= 5;

            // Mover pictureBox2 a la derecha
            if (pictureBox2.Right < this.ClientSize.Width)
                pictureBox2.Left += 5;
        }

        private int ObtenerDistancia(string origen, string destino)
        {
            // Caso 1: Centro -> Norte
            if (origen == "Centro" && destino == "Norte") return 500; // 500 metros

            // Caso 2: Centro -> Sur
            else if (origen == "Centro" && destino == "Sur") return 500;

            // Caso 3: Centro -> Este
            else if (origen == "Centro" && destino == "Este") return 400;

            // Caso 4: Centro -> Oeste
            else if (origen == "Centro" && destino == "Oeste") return 300;

            // Caso 5: Norte -> Centro
            else if (origen == "Norte" && destino == "Centro") return 500;

            return 300; // Distancia genérica (ej: 300 metros)
        }

        private int CalcularTiempoEstimado(string origen, string destino, int vehiculosEnEspera)
        {
            int distancia = ObtenerDistancia(origen, destino);
            double velocidadMs = 8.33; // 30 km/h
            double factorCongestion = 1 + (vehiculosEnEspera / 5 * 0.1);
            double tiempoSegundos = (distancia / velocidadMs) * factorCongestion;
            return (int)Math.Ceiling(tiempoSegundos / 60);
        }

        private void btnDetenerSimulacion_Click(object sender, EventArgs e)
        {
            timerSimulacion.Stop();
            btnSimular.Enabled = true;
            btnDetenerSimulacion.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar los ListBox
                lstFlujoVehiculos.Items.Clear();
                lstCongestiones.Items.Clear();

                // Obtener datos de flujo
                var flujoVehiculos = new ConexionBD().ObtenerFlujoVehiculos();
                lstFlujoVehiculos.Items.Add("FLUJO DE VEHÍCULOS");
                lstFlujoVehiculos.Items.Add("---------------------");

                foreach (DataRow row in flujoVehiculos.Rows)
                {
                    string item = $"{row["Ruta"]}: {row["CantidadVehiculos"]} | Tiempo Promedio: {row["TiempoPromedioCruce"]} min";
                    lstFlujoVehiculos.Items.Add(item);
                }

                // Obtener datos de congestión
                var congestiones = new ConexionBD().ObtenerCongestiones();
                lstCongestiones.Items.Add("CONGESTIONES POR INTERSECCIÓN");
                lstCongestiones.Items.Add("-----------------------------");

                foreach (DataRow row in congestiones.Rows)
                {
                    string item = $"{row["NombreInterseccion"]}: {row["CantidadVehiculos"]} vehículos";
                    lstCongestiones.Items.Add(item);
                }

                // Mostrar la pestaña de reportes
                tabControl1.SelectedTab = tabPage4;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reportes: {ex.Message}");
            }
        }


        ////



    }
}