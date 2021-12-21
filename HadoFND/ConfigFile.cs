﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace HadoFND
{
    public class ConfigFile
    {
        public ConfigFile()
        {

        }

        string _comport = "COM1";
        public string Comport
        {
            get
            {
                return _comport;
            }

            set
            {
                _comport = value;
            }
        }

        int _set_baudrate = 2400;
        public int BaudRate
        {
            get { return _set_baudrate; }
            set { _set_baudrate = value; }
        }

        Parity _set_parity = Parity.Even;
        public Parity Parity
        {
            get { return _set_parity; }
            set { _set_parity = value; }
        }

        int _set_databits = 7;
        public int DataBits
        {
            get { return _set_databits; }
            set { _set_databits = value; }
        }


        StopBits _set_sb = StopBits.One;
        public StopBits StopBits
        {
            get { return _set_sb; }
            set { _set_sb = value; }
        }

        string _led_comport = "COM2";
        public string Led_Comport
        {
            get
            {
                return _led_comport;
            }

            set
            {
                _led_comport = value;
            }
        }

        int _led_set_baudrate = 2400;
        public int Led_BaudRate
        {
            get { return _led_set_baudrate; }
            set { _led_set_baudrate = value; }
        }

        Parity _led_set_parity = Parity.None;
        public Parity Led_Parity
        {
            get { return _led_set_parity; }
            set { _led_set_parity = value; }
        }

        int _led_set_databits = 8;
        public int Led_DataBits
        {
            get { return _led_set_databits; }
            set { _led_set_databits = value; }
        }

        StopBits _led_set_sb = StopBits.One;
        public StopBits Led_StopBits
        {
            get { return _led_set_sb; }
            set { _led_set_sb = value; }
        }

        string _db_IP = "127.0.0.1";

        public string Db_IP
        {
            get { return _db_IP; }
            set { _db_IP = value; }
        }

        string _db_Name = "hado";

        public string Db_NAME
        {
            get { return _db_Name; }
            set { _db_Name = value; }
        }

        string _db_ID = "root";

        public string Db_ID
        {
            get { return _db_ID; }
            set { _db_ID = value; }
        }

        string _db_PW = "root";

        public string Db_PW
        {
            get { return _db_PW; }
            set { _db_PW = value; }
        }

        int _db_PORT = 3306;

        public int Db_PORT
        {
            get { return _db_PORT; }
            set { _db_PORT = value; }
        }

        int _hi_Value = 50;

        public int Hi_Value
        {
            get { return _hi_Value; }
            set { _hi_Value = value; }
        }

        int _lo_Value = 50;

        public int Lo_Value
        {
            get { return _lo_Value; }
            set { _lo_Value = value; }
        }

        // 최소 무게
        // 최소 무게를 초과해야 DB에 저장 된다.
        int _min_weight = 50;

        public int Min_Weight
        {
            get { return _min_weight; }
            set { _min_weight = value; }
        }

        string filename = "config.dat";


        /// <summary>
        /// 파일저장
        /// </summary>
        public void Save()
        {
            try
            {
                string fname = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

                System.IO.FileStream fs = new System.IO.FileStream(fname, System.IO.FileMode.Create);
                System.Xml.Serialization.XmlSerializer sz = new System.Xml.Serialization.XmlSerializer(typeof(ConfigFile));
                sz.Serialize(fs, this);
                fs.Close();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }


        /// <summary>
        /// 읽어오기
        /// </summary>
        /// <returns></returns>
        public ConfigFile Load()
        {
            try
            {
                string fname = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

                if (!System.IO.File.Exists(fname)) Save();

                //파일이 존재하지만 empty 일경우


                System.IO.FileStream fs = new System.IO.FileStream(fname, System.IO.FileMode.Open);
                System.Xml.Serialization.XmlSerializer sz = new System.Xml.Serialization.XmlSerializer(typeof(ConfigFile));
                ConfigFile result = (ConfigFile)sz.Deserialize(fs);
                fs.Close();

                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new ConfigFile();
            }
        }
    }
}