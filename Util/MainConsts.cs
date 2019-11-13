﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TptMain.Util
{
    /// <summary>
    /// Utility constants.
    /// </summary>
    public static class MainConsts
    {
        /// <summary>
        /// JSON MIME type (this is .NET core, but not framework).
        /// </summary>
        public const string APPLICATION_JSON_MIME_TYPE = "application/json";

        /// <summary>
        /// Default server URI. Needs to be configurable, in future.
        /// </summary>
        public const string DEFAULT_SERVER_URI = "http://10.20.2.4:9875/api";

        /// <summary>
        /// Progress form update frequency in x/sec.
        /// </summary>
        public const int PROGRESS_FORM_UPDATE_RATE_IN_FPS = 10;

        /// <summary>
        /// Preview job update interval in sec.
        /// </summary>
        public const int PREVIEW_JOB_UPDATE_INTERVAL_IN_SEC = 5;

        /// <summary>
        /// Target preview job time.
        /// 
        /// This is used to animate preview progress bar, as there's no server-side incremental progress, at this time
        /// (generally accurate, as enqued but not executing jobs are distinguishable and indicated differently).
        /// </summary>
        public const int TARGET_PREVIEW_JOB_TIME_IN_SEC = 90;
    }
}
