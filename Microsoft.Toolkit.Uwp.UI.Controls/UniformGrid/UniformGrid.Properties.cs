﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// The UniformGrid spaces items evenly.
    /// </summary>
    public partial class UniformGrid
    {
        /// <summary>
        /// Identifies the <see cref="Columns"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.Register("Columns", typeof(int), typeof(UniformGrid), new PropertyMetadata(0, OnColumnsChanged));

        /// <summary>
        /// Identifies the <see cref="FirstColumn"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FirstColumnProperty =
            DependencyProperty.Register("FirstColumn", typeof(int), typeof(UniformGrid), new PropertyMetadata(0, OnColumnsChanged));

        /// <summary>
        /// Identifies the <see cref="Rows"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty RowsProperty =
            DependencyProperty.Register("Rows", typeof(int), typeof(UniformGrid), new PropertyMetadata(0));

        private static void OnColumnsChanged(DependencyObject d, object newValue)
        {
            var self = d as UniformGrid;

            if (self.FirstColumn >= self.Columns)
            {
                //self.FirstColumn = 0;
            }

            //self.RecalculateLayout();
        }

        /// <summary>
        /// Gets or sets the number of columns in the UniformGrid.
        /// </summary>
        public int Columns
        {
            get { return (int)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        /// <summary>
        /// Gets or sets the starting column offset for the first row of the UniformGrid.
        /// </summary>
        public int FirstColumn
        {
            get { return (int)GetValue(FirstColumnProperty); }
            set { SetValue(FirstColumnProperty, value); }
        }

        /// <summary>
        /// Gets or sets the number of rows in the UniformGrid.
        /// </summary>
        public int Rows
        {
            get { return (int)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }
    }
}
