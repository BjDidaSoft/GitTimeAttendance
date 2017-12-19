﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjDiDaSoft.Core.Application.BusinessLayer
{
    /// <summary>
    /// Descripción breve de JQGridItem
    /// </summary>
    public class JQGridItem
    {
        #region Passive attributes

        private long _id;
        private List<string> _row;

        #endregion

        #region Properties

        /// <summary>
        /// RowId de la fila.
        /// </summary>
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Fila del JQGrid.
        /// </summary>
        public List<string> Row
        {
            get { return _row; }
            set { _row = value; }
        }

        #endregion

        #region Active Attributes

        /// <summary>
        /// Contructor.
        /// </summary>
        public JQGridItem(long pId, List<string> pRow)
        {
            _id = pId;
            _row = pRow;
        }

        #endregion

    }
}