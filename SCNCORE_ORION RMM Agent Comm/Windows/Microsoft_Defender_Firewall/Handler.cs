using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;
using Global.Helper;
using SCNCORE_ORION_RMM_Agent_Comm;

namespace Windows.Microsoft_Defender_Firewall
{
    internal class Handler
    {
        // Check if Windows Firewall is enabled
        public static bool Status()
        {
            try
            {
                INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr", false));
                return mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
            }
            catch (Exception ex)
            {
                Logging.Error("Microsoft_Defender_Firewall.Handler.Status", "Windows Firewall Status", ex.ToString());
                return false;
            }
        }
        
        public static void SCNCORE_ORION_RMM_Comm_Agent_Rule_Outbound()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                // Check if SCNCORE_ORION service rule is existing
                bool rule_existing = firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == "SCNCORE_ORION RMM Comm Agent Outbound");

                // Create SCNCORE_ORION service rule if not existing
                if (!rule_existing)
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Outbound", "rule_existing", rule_existing.ToString());

                    INetFwRule2 new_rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    new_rule.Name = "SCNCORE_ORION RMM Comm Agent Outbound";
                    new_rule.Enabled = true;
                    new_rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    new_rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    new_rule.ApplicationName = Application_Paths.SCNCORE_ORION_service_exe;
                    firewallPolicy.Rules.Add(new_rule);
                }
                else
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Outbound", "rule_existing", rule_existing.ToString());
                }
            }
            catch (Exception ex)
            {
                Logging.Error("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Outbound", "Add SCNCORE_ORION service rule (outbound)", ex.Message);
            }
        }

        public static void SCNCORE_ORION_RMM_Comm_Agent_Rule_Inbound()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                // Check if SCNCORE_ORION service rule is existing
                bool rule_existing = firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == "SCNCORE_ORION RMM Comm Agent Inbound");

                // Create SCNCORE_ORION service rule if not existing
                if (!rule_existing)
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Inbound", "rule_existing", rule_existing.ToString());

                    INetFwRule2 new_rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    new_rule.Name = "SCNCORE_ORION RMM Comm Agent Inbound";
                    new_rule.Enabled = true;
                    new_rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                    new_rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    new_rule.ApplicationName = Application_Paths.SCNCORE_ORION_service_exe;
                    firewallPolicy.Rules.Add(new_rule);
                }
                else
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Inbound", "rule_existing", rule_existing.ToString());
                }
            }
            catch (Exception ex)
            {
                Logging.Error("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Comm_Agent_Rule_Inbound", "Add SCNCORE_ORION service rule (inbound)", ex.Message);
            }
        }

        public static void SCNCORE_ORION_RMM_Health_Service_Rule()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                // Check if SCNCORE_ORION service rule is existing
                bool rule_existing = firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == "SCNCORE_ORION RMM Health Agent");

                // Create SCNCORE_ORION service rule if not existing
                if (!rule_existing)
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Health_Service_Rule", "rule_existing", rule_existing.ToString());

                    INetFwRule2 new_rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    new_rule.Name = "SCNCORE_ORION RMM Health Agent";
                    new_rule.Enabled = true;
                    new_rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    new_rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    new_rule.ApplicationName = Application_Paths.SCNCORE_ORION_health_service_exe;
                    firewallPolicy.Rules.Add(new_rule);
                }
                else
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Health_Service_Rule", "rule_existing", rule_existing.ToString());
                }
            }
            catch (Exception ex)
            {
                Logging.Error("Microsoft_Defender_Firewall.SCNCORE_ORION_RMM_Health_Service_Rule", "Add SCNCORE_ORION health service rule", ex.Message);
            }
        }

        public static void SCNCORE_ORION_Installer_Rule()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                // Check if SCNCORE_ORION installer rule is existing
                bool rule_existing = firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == "SCNCORE_ORION RMM Installer");

                // Create SCNCORE_ORION service rule if not existing
                if (!rule_existing)
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_Installer_Rule", "rule_existing", rule_existing.ToString());

                    INetFwRule2 new_rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    new_rule.Name = "SCNCORE_ORION RMM Installer";
                    new_rule.Enabled = true;
                    new_rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    new_rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    new_rule.ApplicationName = Application_Paths.c_temp_installer_path;
                    firewallPolicy.Rules.Add(new_rule);
                }
                else
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_Installer_Rule", "rule_existing", rule_existing.ToString());
                }
            }
            catch (Exception ex)
            {
                Logging .Error("Microsoft_Defender_Firewall.SCNCORE_ORION_Installer_Rule", "Add SCNCORE_ORION installer rule", ex.Message);
            }
        }

        public static void SCNCORE_ORION_Uninstaller_Rule()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                // Check if SCNCORE_ORION installer rule is existing
                bool rule_existing = firewallPolicy.Rules.Cast<INetFwRule>().Any(rule => rule.Name == "SCNCORE_ORION RMM Uninstaller");

                // Create SCNCORE_ORION service rule if not existing
                if (!rule_existing)
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_Uninstaller_Rule", "rule_existing", rule_existing.ToString());

                    INetFwRule2 new_rule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    new_rule.Name = "SCNCORE_ORION RMM Uninstaller";
                    new_rule.Enabled = true;
                    new_rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    new_rule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    new_rule.ApplicationName = Application_Paths.c_temp_installer_path;
                    firewallPolicy.Rules.Add(new_rule);
                }
                else
                {
                    Logging.Microsoft_Defender_Firewall("Microsoft_Defender_Firewall.SCNCORE_ORION_Uninstaller_Rule", "rule_existing", rule_existing.ToString());
                }
            }
            catch (Exception ex)
            {
                Logging.Error("Microsoft_Defender_Firewall.SCNCORE_ORION_Uninstaller_Rule", "Add SCNCORE_ORION uninstaller rule", ex.Message);
            }
        }
    }
}
