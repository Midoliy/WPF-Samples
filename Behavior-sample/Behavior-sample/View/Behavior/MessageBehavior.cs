﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Behavior_sample.View.Behavior
{
    public class MessageBehavior : Behavior<Button>
    {
        public string Message
        {
            get => GetValue(Text) as string;
            set => SetValue(Text, value);
        }
        public static readonly DependencyProperty Text;


        static MessageBehavior()
        {
            Text = DependencyProperty.Register("Message", typeof(string), typeof(MessageBehavior), new UIPropertyMetadata(null));
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Click += ShowMessage;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.Click -= ShowMessage;
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Message))
            {
                return;
            }

            MessageBox.Show(Message);
        }
    }
}
