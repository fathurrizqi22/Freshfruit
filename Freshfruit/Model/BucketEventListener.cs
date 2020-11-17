using System;
using System.Collections.Generic;
using System.Text;

namespace Freshfruit.Model
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
