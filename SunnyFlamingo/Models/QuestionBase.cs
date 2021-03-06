﻿using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class QuestionBase<T>
    {
        public QuestionBase()
        {

        }
        public QuestionBase(DBQuestionBase dBQuestionBase)
        {
            AfterBox = dBQuestionBase.AfterBox;
            Checked = dBQuestionBase.Checked;
            Key = dBQuestionBase.Key;
            Label = dBQuestionBase.Label;
            From = Convert.ToDecimal(dBQuestionBase.From, new CultureInfo("en-US"));
            To = Convert.ToDecimal(dBQuestionBase.To, new CultureInfo("en-US"));
        }
        public string QuestionsKey { get; set; }
        public T Value { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public int? Order { get; set; }
        public ControlType ControlType { get; set; }
        public InputType Type { get; set; }
        public List<QuestionOption> Options { get; set; }
        public bool? Checked { get; set; }
        public int? AfterBox { get; set; }
        public object SelectedFrom { get; set; }
        public object SelectedTo { get; set; }
        public object From { get; set; }
        public object To { get; set; }
        public QuestionValidator Validator { get; set; }
        public string MethodName { get; set; }
    }
}
