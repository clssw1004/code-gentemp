package com.qgbase.${bizName}.dic.service;

import com.qgbase.biz.${bizName}.domain.TDic;
import com.qgbase.common.TBaseBo;
import com.qgbase.common.dao.CommonDao;
import com.qgbase.common.domain.OperInfo;
import com.qgbase.config.exception.SysRunException;
import com.qgbase.permission.service.IPermissionFacade;
import com.qgbase.permission.utils.StringUtils;
import com.qgbase.util.StringUtil;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.List;

$include{signature}
@Component
public class ${modelName}Service extends TBaseBo<${modelName}>{
    @Autowired
    CommonDao commonDao;
    @Autowired
    IPermissionFacade permissionFacade;

    @Override
    public ${modelName} createObj() {
        return new ${modelName}();
    }

    @Override
    public Class getEntityClass() {
        return ${modelName}.class;
    }

    /**
     * 新建对象
     * @param oper 操作人
     * @return 返回值
     * @throws Exception 异常
     */
    @Override
    public ${modelName} newObj(OperInfo oper) throws Exception {
        ${modelName} ${modelNameVariable}= super.newObj(oper);
        return ${modelNameVariable};
    }
    /**
     * 检查操作权限
     * @param amethod 方法名
     * @param obj     业务对象
     * @param oper    操作者
     * @return 返回对象
     */
    @Override
    protected boolean checkOpRole(String amethod, ${modelName} obj, OperInfo oper) {
        return super.checkOpRole(amethod, obj, oper);
    }

    @Override
    public String checkAddorUpdate(TDic obj, OperInfo oper, boolean isNew) throws Exception {
        return super.checkAddorUpdate(obj, oper, isNew);
    }

    @Override
    public TDic addobj(${modelName} obj, OperInfo oper) throws Exception {
        return super.addobj(obj, oper);
    }
}
