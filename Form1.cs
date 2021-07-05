using System;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace TCP_IP_Sokets_AppDistribuidas{
    public partial class Cliente : Form{
        public Cliente(){
            InitializeComponent();
            txtIP.Text = obtenerIP(); //metodo que obtiene mi ip de la maquina y asigna al cliente
        }

        private string obtenerIP(){
            String strHostName = string.Empty;//creo un string que contendra el hostname
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());//creo un string que contendra el hostname
            IPAddress[] addr = ipEntry.AddressList;//guardo en un vector la entra de ips
            return addr[1].ToString() + ":9000";//retorna la ip con el puerto 9000
        }

        SimpleTcp.SimpleTcpClient client;//Creacion De La Variable Tcp Tipo Cliente


        private void btnEnviar_Click(object sender, EventArgs e){
            if (client.IsConnected){//si el cliente esta conectado haga lo siguiente
                if (!string.IsNullOrEmpty(txtMensage.Text)){//si el campo de mensaje no esta vacio haag lo demas
                    client.Send(txtMensage.Text);//envio el mensaje
                    txtInfo.Text += $"ME: {txtMensage.Text}{Environment.NewLine}";//asigno al txt info el mensaje
                    txtMensage.Text = string.Empty;// vacio el txt mensaje luego de enviar el mensaje
                }
            }
        }

        private void btnConectar_Click(object sender, EventArgs e){
            //un try catch para ver si se conecta al servidor si no que muestre un mensaje de error 
            try{
                client = new SimpleTcp.SimpleTcpClient(txtIP.Text);//mando ala variable client en su constructor la ip que tengo asignada en el txtip
                //Creo los metodos conectado desconectado y datos recibidos 
                client.Events.Connected += Events_Connected;
                client.Events.Disconnected += Events_Disconnected; ;
                client.Events.DataReceived += Events_DataReceived;
                ///////////////////////////////////////////////////////////
                btnEnviar.Enabled = false;//desactivo el boton de enviar
                client.Connect();//establezco la conexion
                //habilito o desabilito botones y txt segun sea el caso de conectarse
                btnEnviar.Enabled = true;
                btnConectar.Enabled = false;
                txtIP.Enabled = false;
            }catch (Exception ex){
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//muestro el mensaje de error si se produce alguno
            }
        }

        private void Events_Disconnected(object sender, SimpleTcp.ClientDisconnectedEventArgs e){
            this.Invoke((MethodInvoker)delegate {//sincroniza delega y actualiza los elementos de la interfaz
                txtInfo.Text = "";
                txtInfo.Text += $"Servidor Desconectado.{Environment.NewLine}";//guardo mensaje de desconectado
                //habilito y desabilitos botones y txt segun el caso de desconectado
                btnConectar.Enabled = true;
                txtIP.Enabled = true;
                btnEnviar.Enabled = false;
            });

        }

        private void Events_DataReceived(object sender, SimpleTcp.DataReceivedEventArgs e){
            this.Invoke((MethodInvoker)delegate {
                txtInfo.Text += $"Servidor: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";//guardo mensaje recibido
            });
        }

        private void Events_Connected(object sender, SimpleTcp.ClientConnectedEventArgs e){
            this.Invoke((MethodInvoker)delegate {
                txtInfo.Text += $"Servidor Conectado.{Environment.NewLine}";//guardo mensaje de conectado
            });      
        }

        private void Cliente_Load(object sender, EventArgs e) {
            btnEnviar.Enabled = false;//al inciar no se podra utilizar el boton enviar
        }
    }
}
