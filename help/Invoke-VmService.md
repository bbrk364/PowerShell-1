---
external help file: NutanixIntentfulAPI-help.xml
Module Name: NutanixIntentfulAPI
online version:
schema: 2.0.0
---

# Invoke-VmService

## SYNOPSIS

## SYNTAX

### FilterKindLengthOffsetSortAttributeSortOrder
```
Invoke-VmService -GetEntitiesRequest <IVmListMetadata> [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] [-username <String>] [-password <String>] [-SkipSSL] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### FilterKindLengthOffsetSortAttributeSortOrderExpanded
```
Invoke-VmService [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>]
 [-Proxy <Uri>] [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-username <String>]
 [-password <String>] [-Filter <String>] [-Kind <String>] [-Length <Int32>] [-Offset <Int32>]
 [-SortAttribute <String>] [-SortOrder <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
{{Fill in the Description}}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -Filter
The filter in FIQL syntax used for the results.

```yaml
Type: System.String
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GetEntitiesRequest
All api calls that return a list will have this metadata block as input

```yaml
Type: Nutanix.Powershell.Models.IVmListMetadata
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrder
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -HttpPipelineAppend
SendAsync Pipeline Steps to be appended to the front of the pipeline

```yaml
Type: Microsoft.Rest.ClientRuntime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelinePrepend
SendAsync Pipeline Steps to be prepended to the front of the pipeline

```yaml
Type: Microsoft.Rest.ClientRuntime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Kind
The kind name

```yaml
Type: System.String
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Length
The number of records to retrieve relative to the offset

```yaml
Type: System.Int32
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Offset
Offset from the start of the entity list

```yaml
Type: System.Int32
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -password
The password for authentication

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Proxy
The URI for the proxy server to use

```yaml
Type: System.Uri
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyCredential
Credentials for a proxy server to use for the remote call

```yaml
Type: System.Management.Automation.PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyUseDefaultCredentials
Use the default credentials for the proxy

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipSSL
Skip the ssl validation

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrder
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SortAttribute
The attribute to perform sort on

```yaml
Type: System.String
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SortOrder
The sort order in which results are returned

```yaml
Type: System.String
Parameter Sets: FilterKindLengthOffsetSortAttributeSortOrderExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -username
The username for authentication

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS