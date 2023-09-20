﻿using System;

namespace Volo.Abp.Validation.StringValues;

[Serializable]
[StringValueType("SELECTION")]
public class SelectionStringValueType : StringValueTypeBase
{
    public ISelectionStringValueItemSource ItemSource { get; set; } = default!;

    public SelectionStringValueType()
    {

    }

    public SelectionStringValueType(IValueValidator validator)
        : base(validator)
    {

    }
}