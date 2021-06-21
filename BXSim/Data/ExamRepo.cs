using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Data
{
    public class ExamRepo : IExamRepo
    {
        private BXSimDbContext context;
        public ExamRepo(BXSimDbContext ctx)
        {
            context = ctx;
        }
        public List<IExamItem> Questions
        {
            get
            {
                return new List<IExamItem>
                {
#region QuestionSet1
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
                    new ComplexStatementExamItem {
                        Statement = new (HtmlTag, string)[] {
                        new (HtmlTag.p, "You have an Azure subscription named Subscription1 You sign in to Azure portal and create a resource group named RG1."),
                        new (HtmlTag.p, "From Azure documentation, you have the folloing command that creates a virtual machine named VM1."),
                        new (HtmlTag.code, "az vm create --resource-group RG1 -name VM1 --image UbuntuLTS --generate-ssh-keys"),
                        new (HtmlTag.p, "You need to create VM1 in Subscription1 by using the command."),
                        new (HtmlTag.p, "Solution: From the Azure portal, launch Azure Cloud Shell and select Bash, run the command in Cloud Shell, Does this meet the goal?")
                        },
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
                    new ComplexStatementExamItem {
                        Statement = new (HtmlTag t, string s)[]
                        {
                            new (HtmlTag.p, "An Azure administrator plans to run a PowerShell script that creates Azure resources. You need to recommend which computer configuration to use to run the script."),
                            new (HtmlTag.p, "Solution: Run the script from a computer that runs macOS and has PowerShell Core 6.0 installed. Does this meet the goal?")
                        },
                        Answer = "Yes"
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
                    new ExamItem("An Azure resource can have multiple Delete locks", "Yes"),
                    new ExamItem("An Azure resource inherits locks from its resource group", "Yes"),
                    new ExamItem("If an Azure resource has a Read-only lock, you can add a Delete lock to the resouce", "Yes"),
                    new ExamItem{Statement = "If a resource group named RG1 has a delete lock, ________ can delete RG1",
                    Options = new string[]
                    {
                        "Only a member of the global administrators group",
                        "the delete lock must be removed before an administrator",
                        "an Azure policy must be modified before an administrator",
                        "an Azure tag must be added before an administrator"
                    },
                    Answer = "the delete lock must be removed before an administrator"},
                    new ComplexStatementExamItem {
                        Statement = new (HtmlTag t, string s)[]
                        {
                            new (HtmlTag.p, "Your company plans to migrate all its data and resources to Azure."),
                            new (HtmlTag.p, "The company's migration plan states that only PaaS solutions must be used in Azure."),
                            new (HtmlTag.p, "You need to deploy an Azure environment that supports the planned migration."),
                            new (HtmlTag.p, "Solution: You create an Azure App Service and Azure Storage accounts. Does this meet the goal?"),
                        },
                        Answer = "No"
                    },
                    new ComplexStatementExamItem {
                        Statement = new (HtmlTag t, string s)[]
                        {
                            new (HtmlTag.p, "You plan to migrate a web app to Azure, the web app is accessed by external users."),
                            new (HtmlTag.p, "You need to recommend a cloud deployment solution to minimiaze the amount of administrative effort used to manage the web application."),
                            new (HtmlTag.p, "What should you include in the recommendation?"),
                        },
                        Options = new string[]
                        {
                            "SaaS","PaaS","IaaS","DaaS"
                        },
                        Answer = "PaaS"
                    },
                    new ComplexStatementExamItem {
                        Statement = new (HtmlTag t, string s)[]
                        {
                            new (HtmlTag.p, "Your network contains an AD forest. The forest contains 5,000 user accounts."),
                            new (HtmlTag.p, "Your company plans to migrate all network resources to Azure and to decommision the on-premise data center."),
                            new (HtmlTag.p, "You need to recommend a solution to minimize the impact on users after the planned migration. What should you recommend?"),
                        },
                        Options = new string[]
                        {
                            "Implement Azure Multi-Factor Authentication (MFA)",
                            "Sync all the Active Directory user accounts to Azure Active Directory (Azure AD)",
                            "Instruct all users to change their password",
                            "Create a guest user account in Azure AD for each user"
                        },
                        Answer = "Sync all the Active Directory user accounts to Azure Active Directory (Azure AD)"
                    },
                    new ExamItem("An Azure service in private preview is released to all Azure customers", "No"),
                    new ExamItem("An Azure service in public preview is released to all Azure customers", "Yes"),
                    new ExamItem("An Azure service in general availability is released to a subset of Azure customers", "No"),
                    new ExamItem
                    {
                        Statement = "When you need to delete permissions to several Azure VMs simultaneously, you must deploy the Azure VMs to ________.",
                        Options = new string[]
                        {
                            "to the same Azure region",
                            "by using the same Azure Resource Manager template",
                            "to the same resource group",
                            "to the same availability zone",
                        },
                        Answer = "to the same resource group"
                    },
                    new ComplexStatementExamItem
                    {
                        Statement = new (HtmlTag, string)[]
                        {
                            (HtmlTag.p, "You plan to deploy serveral Azure VMs."),
                            (HtmlTag.p, "You need to control the ports that devices on the internet can use to access the VMs."),
                            (HtmlTag.p, "What should you use?"),
                        },
                        Options = new string[]
                        {
                            "an Azure AD role",
                            "an Azure Key Vault",
                            "an Azure AD group",
                            "a network security group (NSG)",
                        },
                        Answer = "a network security group (NSG)"
                    },
#endregion
#region QuestionSet2
                    new ComplexStatementExamItem
                    {
                        Statement = new (HtmlTag, string)[]
                        {
                            (HtmlTag.p, "You plan to deploy several Azure VMs"),
                            (HtmlTag.p, "You need to ensure that the services running on the VMs are available if a single data center fails."),
                            (HtmlTag.p, "Solution: You deploy the VMs to two or more resouce groups, Does this meet the goal?"),
                        },
                        Answer = "No"
                    },
                    new ExamItem{Statement="You can create an Azure support request from ________.",
                    Options=new string[]
                    {
                        "support.microsoft.com",
                        "the Azure portal",
                        "the Knowledge Center",
                        "the Security & Compliance admin center"
                    },
                    Answer="the Azure portal"
                    },
                    new ExamItem("Data that is copied to an Azure Storage account is maintained automatically in at least three copies.", "Yes"),
                    new ExamItem("All data that is copied to an Azure Storage account is backed up automatically to another Azure data center.", "No"),
                    new ExamItem("An Azure Storage account can contain up to 2TB of data and up to one million files.", "No"),
                    new ExamItem("All Azure services in private preview must be accessed by using a separate Azure portal.", "No"),
                    new ExamItem("Azure services in public preview can be used in production environments.", "Yes"),
                    new ExamItem("Azure services in public preview are subject to an SLA.", "No"),
                    new ExamItem("Azure Monitor can monitor the performance of on-premises computers.", "Yes"),
                    new ExamItem("Azure Monitor can send alerts to Azure Active Directory security groups.", "Yes"),
                    new ExamItem("Azure Monitor can trigger alerts based on data in an Azure Log Analytics workspace", "Yes"),
                    new ExamItem{Statement="Data that is stored in the Archive access tier of an Azure Storage account ________?",
                    Options=new string[] {"can be accessed at any time by using azcopy.exe",
                    "can only be read by using Azure Backup",
                    "must be restored before the data can be accessed.",
                    "must be rehydrated before the data can be accessed"},
                    Answer="must be rehydrated before the data can be accessed"},
                    new ComplexStatementExamItem{Statement=new (HtmlTag, string)[]{
                        new (HtmlTag.p, "You have an on-premises app that sends email notifications automatically based on a rule. "),
                        new (HtmlTag.p, "You plan to migrate the app to Azure."),
                        new (HtmlTag.p, "You need to recommend a serverless computing solution for the app. What should you include in the recommendation?"),
                            },
                    Options=new string[] {"a logic app",
                    "a server image in Azure Marketplace",
                    "an API app",
                    "a web app"},
                    Answer="a logic app"},
                    new ComplexStatementExamItem
                    {
                        Statement = new (HtmlTag, string)[]
                        {
                            new (HtmlTag.p, "Your company has an Azure subscription that contains the following unused resources:"),
                            new (HtmlTag.p, "- 20 user accounts in Azure AD"),
                            new (HtmlTag.p, "- 5 groups in Azure AD"),
                            new (HtmlTag.p, "- 10 public IP addresses"),
                            new (HtmlTag.p, "- 10 network interfaces"),
                            new (HtmlTag.p, "You need to reduce the Azure costs for the company."),
                            new (HtmlTag.p, "Solution: You remove the unused network interfaces. Does this meet the goal?"),
                        },
                        Answer = "No"
                    },
                    new ExamItem
                    {
                        Statement="What is required to use Azure Cost Management?",
                        Options = new string[]
                        {
                            "a Dev/Test subscription",
                            "Software Assurance",
                            "an Enterprise Aggrement (EA)",
                            "a pay-as-you-go subscription"
                        },
                        Answer="an Enterprise Aggrement (EA)"
                    },
                    new ExamItem
                    {
                        Statement="Which cloud deployment is used for Azure VMs?",
                        Options = new string[]
                        {
                            "IaaS",
                            "PaaS",
                            "SaaS"
                        },
                        Answer="IaaS"
                    },
                    new ExamItem
                    {
                        Statement="Which cloud deployment is used for Azure SQL database?",
                        Options = new string[]
                        {
                            "IaaS",
                            "PaaS",
                            "SaaS"
                        },
                        Answer="PaaS"
                    },
                    new ComplexStatementExamItem{Statement = new (HtmlTag, string)[]
                    {
                        new (HtmlTag.p, "You plan to implement an Azure database solution"),
                        new (HtmlTag.p, "You need to implement a database solution that meets the following requirements:"),
                        new (HtmlTag.p, " - Can add data concurrently from multiple regions"),
                        new (HtmlTag.p, " - Can store JSON documents"),
                        new (HtmlTag.p, "Which database service should you deploy?"),
                    },
                    Options = new string[]
                    {
                        "Azure Cosmos DB", "SQL databases",
                        "Azure Database for MySQL servers", "Azure Database for PostgresSQL servers",
                        "SQL servers", "SQL data warehouse",
                        "Azure Database Migration Services", "Redis Caches",
                        "SQL Server stretch databases", "Data factories",
                        "SQL elastic pools", "Virtual clusters",
                        "Managed databases", "Elastic Job agents",
                        "SQL managed instances"
                    },
                    Answer = "Azure Cosmos DB"
                    },
                    new ExamItem
                    {
                        Statement = "Where can you enable just in time (JIT) VM access?",
                        Options = new string[]
                        {
                            "Azure Bastion",
                            "Azure Firewall",
                            "Azure Front Door",
                            "Azure Security Center"
                        },
                        Answer = "Azure Security Center"
                    },
                    new ExamItem{Statement="You have a VM named VM1 that runs Windows Server 2016. VM1 is in the East US Azure region. Which Azure service should you use from the Azure portal to view service failure notifications that can affect the availability of VM1?",
                    Options=new string[]
                    {
                        "Azure Service Fabric",
                        "Azure Monitor",
                        "Azure Virtual Machines",
                        "Azure Advisor"
                    },
                    Answer = "Azure Virtual Machines"
                    },
                    new ComplexStatementExamItem{Statement = new (HtmlTag, string)[]
                    {
                        new (HtmlTag.p,"An Azure administrator plans to run a PowerShell script that creates Azure resources."),
                        new (HtmlTag.p,"You need to recommend which computer configuration to use to run the script."),
                        new (HtmlTag.p,"Solution: Run the script from a computer that runs Linux and has the Azure CLI tools installed. Does this meet the goal?"),
                    },
                    Answer = "No"
                    },
                    new ComplexStatementExamItem{Statement = new (HtmlTag, string)[]
                    {
                        new (HtmlTag.p,"An Azure administrator plans to run a PowerShell script that creates Azure resources."),
                        new (HtmlTag.p,"You need to recommend which computer configuration to use to run the script."),
                        new (HtmlTag.p,"Solution: Run the script from a computer that runs Chrome OS and uses Azure Cloud Shell. Does this meet the goal?"),
                    },
                    Answer = "Yes"
                    },
                    new ExamItem{Statement="You have an Azure environment that contains 10 VNets and 100 VMs. You need to limit the amount of inbound traffic to all the Azure VNets. What should you create?",
                    Options=new string[]
                    {
                        "one application security group (ASG)",
                        "10 VNet gateways",
                        "10 Azure ExpressRoute circuits",
                        "one Azure firewall"
                    },
                    Answer = "one Azure firewall"
                    },
                    new ExamItem{Statement="You plan to deploy a website to Azure. The website will be accessed by users worldwide and will host large video files. You need to recommand which Azure feature must be used to provide the best video playback experience. What should you recommend?",
                    Options = new string[]{
                        "an application gateway",
                        "an Azure ExpressRoute circuit",
                        "a content delivery network (CDN)",
                        "an Azure Traffic Manager profile"
                    },
                    Answer = "a content delivery network (CDN)"
                    }
#endregion
                };
            }
        }

        public IEnumerable<QuizScenario> Scenarios => context.QuizScenarios.Include(q => q.Quizzes);
    }
}
