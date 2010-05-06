/*	FreeTherm.cs

	Copyright 2008 Fred Cooke

	This file is part of the FreeEMS project.

	FreeEMS software is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	FreeEMS software is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with any FreeEMS software.  If not, see <http://www.gnu.org/licenses/>.

	We ask that if you make any changes to this file you send them upstream to us at admin@diyefi.org

	Thank you for choosing FreeEMS to run your engine! */

using System;
using Gtk;
using Glade;
public class FreeTherm
{
        public static void Main (string[] args)
        {
                new FreeTherm (args);
        }
 
        public FreeTherm (string[] args) 
        {
                Application.Init();
 
                Glade.XML gxml = new Glade.XML (null, "freetherm.glade", "MainWindow", null);

                gxml.Autoconnect (this);

                Application.Run();
        }
}

