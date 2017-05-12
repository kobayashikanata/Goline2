﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interface
{
    public interface IAnalyzer<TData, TResult>
    {
        TResult Analysis(TData data, int deep);
    }
}