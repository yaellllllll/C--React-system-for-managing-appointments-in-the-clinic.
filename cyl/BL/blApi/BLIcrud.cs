﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.blApi
{
    public interface BLIcrud<T>
    {
        void Create(T item);
        List<T> Read();

        void Update(T item);

        void Delete(T item);
    }
}
