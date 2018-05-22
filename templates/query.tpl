package com.qgbase.biz.dic.query;

import com.qgbase.common.dao.CommonDao;
import com.qgbase.common.domain.QueryPOB;
import com.qgbase.util.JsonUtil;
import com.qgbase.util.PageControl;
import com.qgbase.util.SecurityUtil;
import com.qgbase.util.StringUtil;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.HashMap;
import java.util.Map;

@Repository
public class TDicQuery {
    @Autowired
    private CommonDao commonDao;

    /**
     * 查询用户列表
     *
     * @param queryMap 查询条件
     * @return 查询结果
     */
    public PageControl queryTDicList(Map queryMap) {
        Map parameter = new HashMap();
        QueryPOB queryPOB = new QueryPOB(queryMap);
        String sql = "select dic_id,dic_code,dic_name,dic_type,is_used,parent_id,dic_desc,create_date,create_user,modify_date,modify_user,dic_data1,dic_data2,pysx from t_dic ";
        String whereSql = " where 1=1   ";
        if (null != queryMap && queryMap.size() > 0) {
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicCode"))) {
                whereSql += " and dic_code like :dicCode";
                parameter.put("dicCode","%" + queryMap.get("dicCode") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicName"))) {
                whereSql += " and dic_name like :dicName";
                parameter.put("dicName","%" + queryMap.get("dicName") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicType"))) {
                whereSql += " and dic_type = :dicType";
                parameter.put("dicType",queryMap.get("dicType"));
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("isUsed"))) {
                whereSql += " and is_used = :isUsed";
                parameter.put("isUsed",queryMap.get("isUsed"));
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("parentId"))) {
                whereSql += " and parent_id = :parentId";
                parameter.put("parentId",queryMap.get("parentId"));
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicDesc"))) {
                whereSql += " and dic_desc like :dicDesc";
                parameter.put("dicDesc","%" + queryMap.get("dicDesc") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicDesc"))) {
                whereSql += " and dic_desc like :dicDesc";
                parameter.put("dicDesc","%" + queryMap.get("dicDesc") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("createUser"))) {
                whereSql += " and create_user like :createUser";
                parameter.put("createUser","%" + queryMap.get("createUser") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("modifyUser"))) {
                whereSql += " and modify_user like :modifyUser";
                parameter.put("modifyUser","%" + queryMap.get("modifyUser") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicData1"))) {
                whereSql += " and dic_data1 like :dicData1";
                parameter.put("dicData1","%" + queryMap.get("dicData1") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("dicData2"))) {
                whereSql += " and dic_data2 like :dicData2";
                parameter.put("dicData2","%" + queryMap.get("dicData2") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("pysx"))) {
                whereSql += " and pysx like :pysx";
                parameter.put("pysx","%" + queryMap.get("pysx") + "%");
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("startDate"))) {
                whereSql += " and create_date >= str_to_date(:startDate,'yyyy-MM-dd')";
                parameter.put("startDate",queryMap.get("startDate"));
            }
            if (StringUtil.isNotBlankIfStr(queryMap.get("endDate"))) {
                whereSql += " and create_date <= str_to_date(:endDate,'yyyy-MM-dd 23:59:59')";
                parameter.put("endDate",queryMap.get("endDate"));
            }

        }
        if (StringUtil.isNotBlankIfStr(queryPOB.getColumnProp()) && StringUtil.isNotBlankIfStr(queryPOB.getColumnOrder())) {
            sql += whereSql + " order by " + queryPOB.getColumnProp() + " " + queryPOB.getColumnOrder();
        } else {
            sql += whereSql + " order by dic_id asc";
        }
        String count = "select count(*) from (" + sql + ") a ";
        PageControl pc = commonDao.getDataBySql(count, sql, queryPOB.getPage(), queryPOB.getLen(), parameter);
        return pc;
    }
}
