package com.qgbase.biz.${bizName}.domain;

import lombok.Data;



$include{signature.tpl}
@Data
public class ${modelName}{

    $for{columns}
    private ${columnType} ${columnName};
    $endfor{columns}
}
