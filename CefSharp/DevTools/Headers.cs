// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Collections.Generic;
using System.Collections.Specialized;

namespace CefSharp.DevTools.Network
{
    //TODO: Properly implement this type
    public class Headers : Dictionary<string, string>
    {
        public Dictionary<string, string> ToDictionary()
        {
            return this;
        }
    }
}
