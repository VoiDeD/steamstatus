﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace StatusService
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }


        public void Start( string[] args )
        {
            OnStart( args );
        }


        protected override void OnStart( string[] args )
        {
            Log.WriteInfo( "Service", "Starting..." );

            MonitorThread.Instance.Start();
        }

        protected override void OnStop()
        {
            Log.WriteInfo( "Service", "Stopping..." );

            MonitorThread.Instance.Stop();
        }
    }
}
