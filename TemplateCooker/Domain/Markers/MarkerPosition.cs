﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TemplateCooker.Domain.Markers
{
    [DebuggerDisplay("SRC({SheetIndex},{RowIndex},{ColumnIndex})")]
    public class MarkerPosition : IEquatable<MarkerPosition>
    {
        public int SheetIndex { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MarkerPosition position &&
                   SheetIndex == position.SheetIndex &&
                   RowIndex == position.RowIndex &&
                   ColumnIndex == position.ColumnIndex;
        }

        public bool Equals(MarkerPosition other)
        {
            return ((object)this).Equals(other);
        }

        public override int GetHashCode()
        {
            int hashCode = 1713590872;
            hashCode = hashCode * -1521134295 + SheetIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + RowIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + ColumnIndex.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(MarkerPosition left, MarkerPosition right)
        {
            return EqualityComparer<MarkerPosition>.Default.Equals(left, right);
        }

        public static bool operator !=(MarkerPosition left, MarkerPosition right)
        {
            return !(left == right);
        }
    }
}