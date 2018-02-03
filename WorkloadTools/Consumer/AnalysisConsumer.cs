﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkloadTools.Consumer
{
    public class AnalysisConsumer : BufferedWorkloadConsumer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public SqlConnectionInfo ConnectionInfo { get; set; }
        public int UploadIntervalSeconds { get; set; }

        public override void Consume(WorkloadEvent evt) 
        {
            base.Consume(evt);
        }
    }
}
