package com.qgbase.biz.${bizName}.controller;

import com.qgbase.common.domain.OperInfo;
import com.qgbase.common.enumeration.EnumResultType;
import com.qgbase.biz.${bizName}.domain.${modelName};
import com.qgbase.biz.${bizName}.service.${modelName}Service;
import com.qgbase.util.JsonUtil;
import com.qgbase.util.TToolRequest;
import io.swagger.annotations.ApiOperation;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;

$include{signature.tpl}
@Controller
@RequestMapping(value = "/api/${namespace}")
public class ${modelName}Controller{
    @Autowired
    ${modelName}Service ${modelNameVariable}Service;
    @ApiOperation(value="添加对象")
    @PostMapping(value = "/addobj")
    @ResponseBody
    public String addobj(@ModelAttribute ${modelName} ${modelNameVariable}, OperInfo opUser) throws Exception {
        ${modelName} ${modelNameVariable}1 = ${modelNameVariable}Service.addobj(${modelNameVariable},opUser);
        return  TToolRequest.Result(EnumResultType.SAVE_SUCCESS.getCode(), EnumResultType.SAVE_SUCCESS.getMsg(),${modelNameVariable}1);
    }
    @ApiOperation(value="查询对象")
    @PostMapping(value = "/getobj")
    @ResponseBody
    public String getobj(@RequestParam("id") String id,OperInfo opUser) throws Exception{
        ${modelName} ${modelNameVariable} = ${modelNameVariable}Service.getobj(id,opUser);
        return  TToolRequest.Result(EnumResultType.SUCCESS.getCode(), EnumResultType.SUCCESS.getMsg(),${modelNameVariable});
    }
    @ApiOperation(value="修改对象")
    @PostMapping(value = "/updateobj")
    @ResponseBody
    public String updateobj(@ModelAttribute ${modelName} ${modelNameVariable}, OperInfo opUser) throws Exception{
        ${modelName} ${modelNameVariable}1 = ${modelNameVariable}Service.updateobj(${modelNameVariable},opUser);
        return  TToolRequest.Result(EnumResultType.UPDATE_SUCCESS.getCode(), EnumResultType.UPDATE_SUCCESS.getMsg(),${modelNameVariable}1);
    }
    @ApiOperation(value="删除对象")
    @PostMapping(value = "/deleteobj")
    @ResponseBody
    public String deleteobj(@RequestParam("id") String id,OperInfo opUser) throws Exception {
        ${modelNameVariable}Service.deleteobj(id,opUser);
        return TToolRequest.Result(EnumResultType.DEL_SUCCESS.getCode(), EnumResultType.DEL_SUCCESS.getMsg(),null);
    }
    @ApiOperation(value="添加初始化对象")
    @PostMapping(value = "/newObj")
    @ResponseBody
    public String newObj(OperInfo opUser) throws Exception {
        ${modelName} ${modelNameVariable} = ${modelNameVariable}Service.newObj(opUser);
        return  TToolRequest.Result(EnumResultType.SUCCESS.getCode(), EnumResultType.SUCCESS.getMsg(),${modelNameVariable});
    }
}
