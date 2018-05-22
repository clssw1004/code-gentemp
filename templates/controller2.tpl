package com.qgbase.biz.${bizName}.controller;

import com.qgbase.biz.${bizName}.query.TDicQuery;
import com.qgbase.biz.user.query.TQuery;
import com.qgbase.common.domain.OperInfo;
import com.qgbase.util.PageControl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.Map;

/**
 * Created by lbb on 2018/4/27.
 * 主要用于：查询列表数据或复杂查询处理
 */
@Controller
@RequestMapping(value = "/api/query")
public class ${modelName}QueryController {
    @Autowired
    ${modelName}Query ${modelNameVariable}Query;
    @PostMapping(value = "/queryTDicList")
    @ResponseBody
    public PageControl query${modelName}List(@RequestBody Map queryMap, OperInfo operInfo){
        return ${modelNameVariable}Query.query${modelName}List(queryMap);
    }
}
