﻿namespace TaskISort;

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}
