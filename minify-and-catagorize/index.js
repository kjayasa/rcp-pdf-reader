const rcpParams = require("../rcp-params-original.json");
const fs = require("fs");
const cbor = require('cbor')

const params = [];

const paramsCategory = {
  commands: {
    unknownType: [],
    enumeratedType: [],
    listType: [],
  },
  info: {
    unknownType: [],
    enumeratedType: [],
    listType: [],
  },
};

const rcp_supported_json_objects = new Map([
  ["rcp_create_preset", 0],
  ["rcp_config", 1],
  ["rcp_cur_audio_vu", 2],
  ["rcp_cur_cam_info", 3],
  ["rcp_cur_clip_list", 4],
  ["rcp_cur_default_in", 5],
  ["rcp_cur_hist", 6],
  ["rcp_cur_int", 7],
  ["rcp_cur_int_edit_i", 8],
  ["rcp_cur_list", 9],
  ["rcp_cur_menu", 10],
  ["rcp_cur_menu_node_", 11],
  ["rcp_cur_point", 12],
  ["rcp_cur_rect", 13],
  ["rcp_cur_status", 14],
  ["rcp_cur_str", 15],
  ["rcp_cur_str_edit_i", 16],
  ["rcp_cur_uint", 17],
  ["rcp_get", 18],
  ["rcp_get_clip_list", 19],
  ["rcp_get_default", 20],
  ["rcp_get_label", 21],
  ["rcp_get_list", 22],
  ["rcp_get_menu", 23],
  ["rcp_get_menu_status", 24],
  ["rcp_get_status", 25],
  ["rcp_label", 26],
  ["rcp_menu", 27],
  ["rcp_menu_status", 28],
  ["rcp_notification", 29],
  ["rcp_notification_g", 30],
  ["rcp_notification_r", 31],
  ["rcp_notification_t", 32],
  ["rcp_set", 33],
  ["rcp_set_relative", 34],
  ["rcp_set_list_relative", 35],
  ["rcp_subscribe", 36],
]);

const rcp_param_type = new Map([
  ["Value", 0],
  ["Action", 1],
  ["Status", 2],
  ["Signal", 3],
  ["Indexed", 4],
]);

for (const rcpParam of rcpParams) {

  let hasTypes = true;
  let isCommandType = false;
  let isListType = false;

  const type = rcpParam.ParamType;

  const newParam = {
    name: rcpParam.ParamName.substring(10),
    type: "",
    desc: rcpParam.Desc,
    supportedOperarions: [],
  };
  if (rcpParam.TypesJson) {
    newParam.types = rcpParam.TypesJson;
  } else {
    hasTypes = false;
  }

  if (type && rcp_param_type.has(type)) {
    newParam.type = rcp_param_type.get(type);
    isCommandType = (newParam.type === 0 || newParam.type === 1);
  } else {
    console.log(`Cannot find type:"${type}" in ${rcpParam.ParamName}`);
  }

  const supportedOps = rcpParam.SupportedObects;

  const supportedOperatons = [];
  for (const so of supportedOps) {
    if (so && rcp_supported_json_objects.has(so)) {
      const soEnum = rcp_supported_json_objects.get(so);
      isListType = isListType || (soEnum === 22);
      supportedOperatons.push(soEnum);
    } else {
      console.log(
        `Cannot find supported operation:"${so}" in ${rcpParam.ParamName}`
      );
    }
  }
  newParam.supportedOperarions = supportedOperatons;

  params.push(newParam);

  if (isCommandType) {
    if (isListType) {
      paramsCategory.commands.listType.push(newParam);
    } else if (hasTypes) {
      paramsCategory.commands.enumeratedType.push(newParam);
    } else {
      paramsCategory.commands.unknownType.push(newParam);
    }
  } else {
    if (isListType) {
      paramsCategory.info.listType.push(newParam);
    } else if (hasTypes) {
      paramsCategory.info.enumeratedType.push(newParam);
    } else {
      paramsCategory.info.unknownType.push(newParam);
    }
  }
}

const paramsJson = JSON.stringify(params);
fs.writeFileSync("rcp-params-minified.json", paramsJson);

const paramsCategoryJson = JSON.stringify(paramsCategory);
fs.writeFileSync("rcp-params-catogries.json", paramsCategoryJson);


const encoded = cbor.encode(params);
fs.writeFileSync("rcp-params-minified.cbor",encoded,"binary");