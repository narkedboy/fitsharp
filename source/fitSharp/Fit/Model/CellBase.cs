﻿// Copyright © 2009 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

namespace fitSharp.Fit.Model {
    public abstract class CellBase: Cell {
        private CellAttributes Attributes { get; set; }

        protected CellBase() { Attributes = new CellAttributes(); }

        public abstract string Text { get; }

	    public void SetAttribute(string key, string value) {
            Attributes.SetAttribute(key, value);
        }

	    public void AddToAttribute(string key, string value, string format) {
	        Attributes.AddToAttribute(key, value, format);
	    }

	    public string GetAttribute(string key) {
            return Attributes.GetAttribute(key);
        }
    }
}
