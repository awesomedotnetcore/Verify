﻿using System;
using System.Collections.Generic;

namespace Verify
{
    public partial class VerifySettings
    {
        internal List<Func<string, string>> instanceScrubbers = new List<Func<string, string>>();

        public void ScrubMachineName()
        {
            AddScrubber(Scrubbers.ScrubMachineName);
        }

        public void AddScrubber(Func<string, string> scrubber)
        {
            Guard.AgainstNull(scrubber, nameof(scrubber));

            instanceScrubbers.Insert(0, scrubber);
        }
    }
}