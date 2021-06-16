using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class ExamRepo : IExamRepo
    {
        public List<ExamItem> Questions
        {
            get
            {
                return new List<ExamItem>
                {
                    new ExamItem
                    {
                        Statement =
"An Azure subscription can have multiple account administrators.",
                        Answer =
"Yes",
                        Explanation =
@"https://docs.microsoft.com/en-us/azure/cost-management-billing/manage/add-change-subscription-administrator By default, the person who creates a new Azure subscription can assign other users administrative access to a subscription."
                    },
                    new ExamItem
                    {
                        Statement =
"An Azure subscription can be managed by using a Microsoft account only",
                        Answer =
"Yes",
                        Explanation =
@"Just remember"
                    },
                    new ExamItem
                    {
                        Statement =
"An Azure resource group can contain multiple Azure subscriptions.",
                        Answer =
"No",
                        Explanation =
@"https://docs.microsoft.com/en-us/azure/role-based-access-control/scope-overview It should be the other way around: a subscription can contain multiple resource groups."
                    },
                    new ExamItem
                    {
                        Statement =
"An Azure subscription can be associated to multiple Azure AD tenants",
                        Answer =
"No",
                        Explanation =
@"If we switch AD ownership of a subscription, the original administrator roles will be lost, causing apps like k8s to fail."
                    },
                    new ExamItem
                    {
                        Statement =
"You can change the Azure AD tenant to which an Azure subscription is associated.",
                        Answer =
"Yes",
                        Explanation =
@"If we switch AD ownership of a subscription, the original administrator roles will be lost, causing apps like k8s to fail."
                    },
                    new ExamItem
                    {
                        Statement =
"When an Azure subscription expires, the associated Azure AD tenant is deleted automatically.",
                        Answer =
"No",
                        Explanation =
@"We need to manually delete the AD tenant"
                    },
                    new ExamItem
                    {
                        Statement =
"What type of failure for which an Azure Availability Zone can be used to protect access to Azure services?",
                        Answer =
"an Azure data center failure",
                        Options = new string[]
{
    "a physical server failure",
    "an Azure region failure",
    "a storage failure",
    "an Azure data center failure"
},
                        Explanation =
@"https://docs.microsoft.com/en-us/azure/availability-zones/az-overview regional failure is too large for Availability zone to handle, while the other two options server failure and storage failure can be handled by datacenter infra support, which is not the purpose of availability zones"
                    },
                    new ExamItem {
                        Statement =
"What is guaranteed in an Azure SLA for VM?",
                        Answer =
"uptime",
                        Options = new string[]
                        {
                            "uptime",
                            "feature availability",
                            "bandwidth",
                            "performance"
                        }
                    },
                    new ExamItem {
                        Statement =
"You have an Azure subscription named Subscription1 You sign in to Azure portal and create a resource group named RG1. From Azure documentation, you have the folloing command that creates a virtual machine named VM1. az vm create --resource-group RG1 -name VM1 --image UbuntuLTS --generate-ssh-keys You need to create VM1 in Subscription1 by using the command. Solution: From the Azure portal, launch Azure Cloud Shell and select Bash, run the command in Cloud Shell, Does this meet the goal?",
                        Answer =
"No"
                    },
                    new ExamItem {
                        Statement =
"What provide a common platform for deploying objects to a cloud infrastructure and for implementing consistency across the Azure environment?",
                        Answer =
"Azure Resource Manager templates",
                    Options = new string[]{
                        "Azure policies",
                        "Resource groups",
                        "Azure Resource Manager templates",
                        "Management groups"
                    } },
                    new ExamItem {
                        Statement =
"Azure Cosmos DB is an example of a what offering?",
                        Answer =
"PaaS",
                    Options = new string[]{
                        "PaaS",
                        "IaaS",
                        "serverless",
                        "SaaS"
                    } },
                    new ExamItem {
                        Statement =
"You need to recommend an Azure solution that encrypts the administrative credentials during the deployment. What should you include in the recommendation?",
                        Answer =
"Azure Key Vault",
                    Options = new string[]{
                        "Azure Key Vault",
                        "Azure Multi-Factor Authentication (MFA)",
                        "Azure Security Center",
                        "Azure Information Protection"
                    } },
                    new ExamItem {
                        Statement =
"An Azure administrator plans to run a PowerShell script that creates Azure resources. You need to recommend which computer configuration to use to run the script.\r\nSolution: Run the script from a computer that runs macOS and has PowerShell Core 6.0 installed. Does this meet the goal?",
                        Answer =
"Yes"
                    },
                    new ExamItem
                    {
                        Statement = "If you have Azure resources deployed to every region, you can implement availability zones in all the regions",
                        Answer = "No"
                    },
                    new ExamItem
                    {
                        Statement = "Only virtual machines that run Windows Server can be created in availability zones.",
                        Answer = "No"
                    },
                    new ExamItem
                    {
                        Statement = "Availability zones are used to replicate data and applications to multiple regions",
                        Answer = "No"
                    },
                    new ExamItem("From Azure portal, you can distinguish between services that are generally available and services that are in public preview.", "Yes"),
                    new ExamItem("After an Azure service becomes generally available, the service is no longer updated with new features.", "No"),
                    new ExamItem("When you create Azure resources for a service in public preview, you must recreate the resources once the service becomes generally available", "No"),
                    new ExamItem {
                        Statement = "Which blade can monitor the health of Azure services?",
                        Options = new string[]{"Monitor", "Subscriptions", "Marketplace", "Advisor"},
                        Answer = "Monitor"
                    },
                    new ExamItem {
                        Statement = "Which blade can browse available virtual machine images?",
                        Options = new string[]{"Monitor", "Subscriptions", "Marketplace", "Advisor"},
                        Answer = "Marketplace"
                    },
                    new ExamItem {
                        Statement = "Which blade can view security recommendations?",
                        Options = new string[]{"Monitor", "Subscriptions", "Marketplace", "Advisor"},
                        Answer = "Advisor"
                    },
                    new ExamItem("All the Azure resources deployed to a resource group must use the same Azure region", "No"),
                    new ExamItem("If you assign a tag to a resource group, all the Azure resources in that group are assigned the same tag", "No"),
                    new ExamItem("If you assign permissions for a user to manage a resource group, the user can manage all the Azure resources in that resource group", "Yes"),
                    new ExamItem
                    {
                        Statement="An Organization that hosts its infrastructure ________ can decommission its data center",
                        Options = new string[] {"in a private cloud", "in a hybrid cloud","in the public cloud", "on a Hyper-V host"},
                        Answer = "in the public cloud"
                    },
                    new ExamItem("By creating additional resource groups in an Azure subscription, additional costs are incurred", "No"),
                    new ExamItem("By copying several GBs of data to Azure from an on-premises network over a VPN, additiona data transfer costs are incurred", "Yes"),
                    new ExamItem("By copying several GBs of data from Azure to an on-premises network over a VPN, additiona data transfer costs are incurred", "No"),
                };
            }
        }
    }
}
