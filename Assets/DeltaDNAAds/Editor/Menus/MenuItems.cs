﻿//
// Copyright (c) 2016 deltaDNA Ltd. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using DeltaDNA.Editor;
using UnityEditor;
using UnityEngine;

namespace DeltaDNAAds.Editor {
    public sealed class MenuItems : MonoBehaviour {
        
        internal const string MENU_PATH = "DeltaDNA/SmartAds/";
        internal const string EDITOR_PATH = "Assets/DeltaDNAAds/Editor/";
        
        [MenuItem(MENU_PATH + "Select Networks", priority = 3)]
        public static void SelectNetworks() {
            WindowHelper.Show<NetworksWindow>("Ad Networks");
        }
    }
}
