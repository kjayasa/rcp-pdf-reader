grammar RcpDoc;


rcpParamBlock: rcpParamName  rcpParamTypeBlock paramDesc supportedObjectValues typesJsonBlock? .*;

rcpParamName :RCP_PARAM_NAME;

rcpParamTypeBlock : PARAM_TYPE_LABEL typeValue;

typeValue : IDENTIFIER (PARAM_TYPE_EXTRA)?;

supportedObjectValues:supportedObjectValue+  ;

supportedObjectValue: SUPPORTED_VALUE | AND_OR ;

paramDesc:.*? SUPPORTED_LABEL;

typesJsonBlock:TYPES_JSON_LABEL jsonKeyValuePair+;



jsonKeyValuePair: JSON_STRING ':' jsonValue;

jsonValue : jsonObject | JSON_NUMBER | JSON_CONST |JSON_STRING;

jsonObject : '{' jsonKeyValuePair+ '}';

//-----------------------------------------------------------------------------------------S


RCP_PARAM_NAME : 'RCP_PARAM_' IDENTIFIER;

PARAM_TYPE_LABEL: 'Type:';

SUPPORTED_LABEL: 'JSON Supported Objects:';

AND_OR:'and/or';

TYPES_JSON_LABEL :'TYPES';

SUPPORTED_VALUE:'rcp_' IDENTIFIER+;

JSON_NUMBER:'-'?([a-fA-F][xX])?[0-9]+(.[0-9]+)?;

JSON_CONST : 'true' | 'false' | 'null' |'NaN';

JSON_STRING : '"' ~["\r\n]* '"' ;

IDENTIFIER:[a-zA-Z0-9_]+;

PARAM_TYPE_EXTRA :'(' ~[ \r\n\t(]+? ')';

WS : [ \r\n\t] + -> channel (HIDDEN);
