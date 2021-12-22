using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO.Ports;
using RJCP.IO.Ports;

namespace HadoFND
{
    public delegate void SerialSettingClosedEventHandler();

    public partial class SerialSettingForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();
        public SerialSettingClosedEventHandler SerialSettingClosedEvent;

        public SerialSettingForm()
        {
            InitializeComponent();
        }

        //
        // 폼 최초 실행
        //
        private void SerialSettingForm_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
        }

        //
        // 폼 로드시 가져오는 데이터
        //
        private void SetDefaultValue()
        {
            //
            // 연결 가능한 시리얼포트 목록 가져오기
            //
            Indicator_Port_ComboBox.DataSource = SerialPortStream.GetPortNames();
            Led_Port_ComboBox.DataSource = SerialPortStream.GetPortNames();

            //
            // 환경설정 파일 로드
            //
            _configFile = _configFile.Load();

            //
            // 환경설정 파일에 저장된 값으로 변경하기
            //

            //
            // 인디케이터
            //

            // 포트
            for(var i = 0; i < Indicator_Port_ComboBox.Items.Count; i++)
            {
                var item = Indicator_Port_ComboBox.Items[i].ToString();
                if(item.Equals(_configFile.Comport))
                {
                    Indicator_Port_ComboBox.SelectedText = item;
                    Indicator_Port_ComboBox.SelectedIndex = i;
                }
            }

            // Baudrate
            for (var i = 0; i < Indicator_BaudRate_ComboBox.Items.Count; i++)
            {
                var item = Convert.ToInt32(Indicator_BaudRate_ComboBox.Items[i]);
                if (item == _configFile.BaudRate)
                {
                    Indicator_BaudRate_ComboBox.SelectedText = item.ToString();
                    Indicator_BaudRate_ComboBox.SelectedIndex = i;
                }
            }

            // DataBits
            for (var i = 0; i < Indicator_Databits_ComboBox.Items.Count; i++)
            {
                var item = Convert.ToInt32(Indicator_Databits_ComboBox.Items[i]);
                if (item == _configFile.DataBits)
                {
                    Indicator_Databits_ComboBox.SelectedText = item.ToString();
                    Indicator_Databits_ComboBox.SelectedIndex = i;
                }
            }

            // Parity
            if (_configFile.Parity == Parity.None)
            {
                Indicator_Parity_ComboBox.SelectedText = "None";
                Indicator_Parity_ComboBox.SelectedIndex = 0;
            }
            else if (_configFile.Parity == Parity.Odd)
            {
                Indicator_Parity_ComboBox.SelectedText = "Odd";
                Indicator_Parity_ComboBox.SelectedIndex = 1;
            }
            else if (_configFile.Parity == Parity.Even)
            {
                Indicator_Parity_ComboBox.SelectedText = "Even";
                Indicator_Parity_ComboBox.SelectedIndex = 2;
            }

            // StopBits
            if (_configFile.StopBits == StopBits.One)
            {
                Indicator_Stopbits_ComboBox.SelectedText = "1";
                Indicator_Stopbits_ComboBox.SelectedIndex = 0;
            }
            else if (_configFile.StopBits == StopBits.One5)
            {
                Indicator_Stopbits_ComboBox.SelectedText = "1.5";
                Indicator_Stopbits_ComboBox.SelectedIndex = 1;
            }
            else if (_configFile.StopBits == StopBits.Two)
            {
                Indicator_Stopbits_ComboBox.SelectedText = "2";
                Indicator_Stopbits_ComboBox.SelectedIndex = 2;
            }

            //
            // 경광등
            //

            // 포트
            for (var i = 0; i < Led_Port_ComboBox.Items.Count; i++)
            {
                var item = Led_Port_ComboBox.Items[i].ToString();
                if (item.Equals(_configFile.Led_Comport))
                {
                    Led_Port_ComboBox.SelectedText = item;
                    Led_Port_ComboBox.SelectedIndex = i;
                }
            }

            // Baudrate
            for (var i = 0; i < Led_BaudRate_ComboBox.Items.Count; i++)
            {
                var item = Convert.ToInt32(Led_BaudRate_ComboBox.Items[i]);
                if (item == _configFile.Led_BaudRate)
                {
                    Led_BaudRate_ComboBox.SelectedText = item.ToString();
                    Led_BaudRate_ComboBox.SelectedIndex = i;
                }
            }

            // DataBits
            for (var i = 0; i < Led_Databits_ComboBox.Items.Count; i++)
            {
                var item = Convert.ToInt32(Led_Databits_ComboBox.Items[i]);
                if (item == _configFile.Led_DataBits)
                {
                    Led_Databits_ComboBox.SelectedText = item.ToString();
                    Led_Databits_ComboBox.SelectedIndex = i;
                }
            }

            // Parity
            if (_configFile.Led_Parity == Parity.None)
            {
                Led_Parity_ComboBox.SelectedText = "None";
                Led_Parity_ComboBox.SelectedIndex = 0;
            }
            else if (_configFile.Led_Parity == Parity.Odd)
            {
                Led_Parity_ComboBox.SelectedText = "Odd";
                Led_Parity_ComboBox.SelectedIndex = 1;
            }
            else if (_configFile.Led_Parity == Parity.Even)
            {
                Led_Parity_ComboBox.SelectedText = "Even";
                Led_Parity_ComboBox.SelectedIndex = 2;
            }

            // StopBits
            if (_configFile.Led_StopBits == StopBits.One)
            {
                Led_Stopbits_ComboBox.SelectedText = "1";
                Led_Stopbits_ComboBox.SelectedIndex = 0;
            }
            else if (_configFile.Led_StopBits == StopBits.One5)
            {
                Led_Stopbits_ComboBox.SelectedText = "1.5";
                Led_Stopbits_ComboBox.SelectedIndex = 1;
            }
            else if (_configFile.Led_StopBits == StopBits.Two)
            {
                Led_Stopbits_ComboBox.SelectedText = "2";
                Led_Stopbits_ComboBox.SelectedIndex = 2;
            }
        }

        // 
        // 저장 버튼
        //
        private void Serial_Save_Button_Click(object sender, EventArgs e)
        {
            // 인디케이터 설정값
            var indicatorPort = Indicator_Port_ComboBox.Text;
            var indicatorBaudrate = Indicator_BaudRate_ComboBox.Text;
            var indicatorDatabits = Indicator_Databits_ComboBox.Text;
            var indicatorParity = Indicator_Parity_ComboBox.Text;
            var indicatorStopbits = Indicator_Stopbits_ComboBox.Text;

            // 경광등 설정값
            var ledPort = Led_Port_ComboBox.Text;
            var ledBaudrate = Led_BaudRate_ComboBox.Text;
            var ledDatabits = Led_Databits_ComboBox.Text;
            var ledParity = Led_Parity_ComboBox.Text;
            var ledStopbits = Led_Stopbits_ComboBox.Text;

            if (indicatorPort.Equals(ledPort))
            { 
                var text = "동일한 포트는 사용할 수 없습니다.";
                MessageBox.Show(text);
                return;
            }

            if (indicatorPort.Equals("") || indicatorPort == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (indicatorBaudrate.Equals("") || indicatorBaudrate == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (indicatorDatabits.Equals("") || indicatorDatabits == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (indicatorParity.Equals("") || indicatorParity == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (indicatorStopbits.Equals("") || indicatorStopbits == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (ledPort.Equals("") || ledPort == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (ledBaudrate.Equals("") || ledBaudrate == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (ledDatabits.Equals("") || ledDatabits == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (ledParity.Equals("") || ledParity == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (ledStopbits.Equals("") || ledStopbits == null)
            {
                var text = "설정값을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            // 인디케이터 통신 설정
            _configFile.Comport = indicatorPort;
            _configFile.BaudRate = Convert.ToInt32(indicatorBaudrate);
            _configFile.DataBits = Convert.ToInt32(indicatorDatabits);
            _configFile.Parity = Parity.None;
            if (indicatorParity == "Even")
            {
                _configFile.Parity = Parity.Even;
            }
            if (indicatorParity == "Odd")
            {
                _configFile.Parity = Parity.Odd;
            }

            _configFile.StopBits = StopBits.One;
            if (indicatorStopbits == "1")
            {
                _configFile.StopBits = StopBits.One;
            }
            if (indicatorStopbits == "1.5")
            {
                _configFile.StopBits = StopBits.One5;
            }
            if (indicatorStopbits == "2")
            {
                _configFile.StopBits = StopBits.Two;
            }

            // 경광등 통신 설정
            _configFile.Led_Comport = ledPort;
            _configFile.Led_BaudRate = Convert.ToInt32(ledBaudrate);
            _configFile.Led_DataBits = Convert.ToInt32(ledDatabits);
            _configFile.Led_Parity = Parity.None;
            if (ledParity == "Even")
            {
                _configFile.Led_Parity = Parity.Even;
            }
            if (ledParity == "Odd")
            {
                _configFile.Led_Parity = Parity.Odd;
            }

            _configFile.Led_StopBits = StopBits.One;
            if (ledStopbits == "1")
            {
                _configFile.Led_StopBits = StopBits.One;
            }
            if (ledStopbits == "1.5")
            {
                _configFile.Led_StopBits = StopBits.One5;
            }
            if (ledStopbits == "2")
            {
                _configFile.Led_StopBits = StopBits.Two;
            }

            _configFile.Save();
            MessageBox.Show("저장되었습니다.");
            SerialSettingClosedEvent();
            this.Close();
        }

        //
        // 종료 버튼
        //
        private void Serial_Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
