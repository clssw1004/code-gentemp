package com.qgbase.biz.${bizName}.domain;

import com.qgbase.common.domain.TBaseEntity;
import lombok.Data;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;

$include{signature.tpl}
@Data
@Entity
@Table(name = "${tbName}")
public class TDic extends TBaseEntity {

    $for{columns}
    @Column(name = "${columnDbName}",columnDefinition = "${columnDbType} COMMENT '${columnComment}'")
    private ${columnType} ${columnName}
    $endfor{columns}

    @Override
    public String getPKid()
    {
        return ${PId};
    }
    @Override
    public  String getObjName(){
        return "${ModelName}";
    }
    @Override
    public  String getObjDesc(){
        return "";
    }

}
