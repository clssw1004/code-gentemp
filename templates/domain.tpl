package com.qgbase.biz.dic.domain;

import com.qgbase.common.domain.TBaseEntity;
import lombok.Data;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;

/**
 * Created by lbb on 2018/5/2.
 * 主要用于：通用字典表管理
 */
@Data
@Entity
@Table(name = "t_dic")
public class TDic extends TBaseEntity {
    @Id
    @Column(name = "dic_id",unique = true,columnDefinition = "varchar(64) COMMENT '字典主键'")
    @NotNull(message = "主键不能为空")
    private String dicId;//create by lbb 数据字典表主键
    @Column(name = "dic_code",columnDefinition = "varchar(64) COMMENT '字典code'")
    @NotNull(message = "字典code不能为空")
    private String dicCode;//create by lbb 数据字典code
    @Column(name = "dic_name",columnDefinition = "varchar(64) COMMENT '字典名字'")
    @NotNull(message = "字典名称不能为空")
    private String dicName;//create by lbb 数据字典名称
    @NotNull(message = "字典类型不能为空")
    @Column(name = "dic_type",columnDefinition = "varchar(64) COMMENT '字典类型'")
    private String dicType;//create by lbb 数据字典类型
    @Column(name = "dic_desc",columnDefinition = "varchar(64) COMMENT '字典描述'")
    private String dicDesc;//create by lbb 数据字典描述
    @Column(name = "parent_id",columnDefinition = "varchar(64) COMMENT '父节点id'")
    private String parentId;//create by lbb 数据字典父节点编码
    @Column(name = "is_used",columnDefinition = "varchar(32) COMMENT '是否使用'")
    @NotNull(message = "是否使用不能为空")
    private Integer isUsed;//create by lbb 数据字典是否使用标记
    @Column(name = "order_no",columnDefinition = "varchar(32) COMMENT '是否排序'")
    private Integer orderNo;//create by lbb 数据字典排序
    @Column(name = "pysx",columnDefinition = "varchar(32) COMMENT '拼音缩写'")
    private String pysx;//create by lbb 数据字典拼音缩写
    @Column(name = "dic_data1",columnDefinition = "varchar(32) COMMENT '数据字典数据备用1'")
    private String dicData1;//create by lbb 数据字典数据备用
    @Column(name = "dic_data2",columnDefinition = "varchar(32) COMMENT '数据字典数据备用2'")
    private String dicData2;//create by lbb 数据字典数据备用

    @Override
    public String getPKid()
    {
        return dicId;
    }
    @Override
    public  String getObjName(){
        return "TDic";
    }
    @Override
    public  String getObjDesc(){
        return "字典";
    }

}
