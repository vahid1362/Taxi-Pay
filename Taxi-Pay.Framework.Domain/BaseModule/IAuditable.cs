using System;

namespace Rayak.Framework.Domain.BaseModule
{
    public interface IAuditable
    {
        /// <summary>تاریخ ایجاد</summary>
        DateTime CreatedOn { set; get; }

        /// <summary>تاریخ تغییر</summary>
        DateTime? ModifiedOn { set; get; }

        ///// <summary>شخص ایجاد کننده</summary>
        //int CreatedBy { set; get; }

        ///// <summary>شخص تغییر دهنده</summary>
        //int? ModifiedBy { set; get; }

        ///// <summary></summary>
        ///// <param name="userId"></param>
        ///// <param name="dateTime"></param>
        //void SetCreatedState(int userId, DateTime dateTime);

        ///// <summary></summary>
        ///// <param name="userId"></param>
        ///// <param name="dateTime"></param>
        //void SetModifiedState(int userId, DateTime dateTime);
    }
}
