using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.ServiceModel.Configuration;

namespace MySecurityBE
{
    public class AsymetricSecurityBE : BindingElement
    {
        private AsymmetricSecurityBindingElement m_asymSecBE;
        public AsymetricSecurityBE()
        {
            MessageSecurityVersion securityVersion = MessageSecurityVersion.WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10;
            SecurityBindingElement securityBE = SecurityBindingElement.CreateMutualCertificateBindingElement(securityVersion, true);
            securityBE.IncludeTimestamp = true;
            securityBE.SetKeyDerivation(false);
            securityBE.SecurityHeaderLayout = SecurityHeaderLayout.Lax;
            securityBE.EnableUnsecuredResponse = true;
            m_asymSecBE = securityBE as AsymmetricSecurityBindingElement;
        }
        public AsymetricSecurityBE(AsymetricSecurityBE other)
        {
            m_asymSecBE = other.m_asymSecBE;
        }
        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
        {
            return m_asymSecBE.BuildChannelListener<TChannel>(context);
        }
        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
        {
            return m_asymSecBE.BuildChannelFactory<TChannel>(context);
        }
        public override BindingElement Clone()
        {
            AsymetricSecurityBE ret = new AsymetricSecurityBE(this);
            return ret;
        }
        public override T GetProperty<T>(BindingContext context)
        {
            return m_asymSecBE.GetProperty<T>(context);
        }
    }
    class AsymetricSecurityBEExtentionElement : BindingElementExtensionElement
    {
        public override Type BindingElementType
        {
            get { return typeof(AsymetricSecurityBE); }
        }

        protected override BindingElement CreateBindingElement()
        {
            return new AsymetricSecurityBE();
        }
    }
}
