﻿/**
 * Lugubris
 * Copyright (C) 2012  Jaco Ruit
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lugubris.RequestHandlers.Dart
{
    public class DartScriptHandler : IRequestHandler
    {
        public byte[] Handle(string requestUri, System.Net.HttpListenerContext context)
        {
            throw new NotImplementedException();
        }

        public bool DoesHandle(string requestUri)
        {
            return requestUri.EndsWith(".dart");
        }
    }
}
