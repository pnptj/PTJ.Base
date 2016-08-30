using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Transactions;
using PTJ;
using PTJ.Base;
using PTJ.Base.Schemas;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace PTJ.ServiceLayer
{
    public class Base<I, O, O1, O2, O3, O4, O5, O6, O7, O8, T, D, VO, WO, XO, YO, ZO, ÅO, ÄO, ÖO, VD, WD, XD, YD, ZD, ÅD, ÄD, ÖD> : System.Web.Services.WebService
    {
        public PTJSoapHeader WebSoapHeader;
        public string CurrentUser;
        public string CurrentDataRole;
        public string CurrentRowLevelSecurity;
        protected O obj = default(O);
        protected O1 obj1 = default(O1);
        protected O2 obj2 = default(O2);
        protected O3 obj3 = default(O3);
        protected O4 obj4 = default(O4);
        protected O5 obj5 = default(O5);
        protected O6 obj6 = default(O6);
        protected O7 obj7 = default(O7);
        protected O8 obj8 = default(O8);
        protected List<object> lstObjs = default(List<object>);
        protected Base.Schemas.TransportMessage<T[]> lstTransportation = default(Base.Schemas.TransportMessage<T[]>);
        protected Base.Schemas.TransportMessage<T> transportation = default(Base.Schemas.TransportMessage<T>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]> lstTransportation1 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]> lstTransportation2 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]> lstTransportation3 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]> lstTransportation4 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]> lstTransportation5 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]> lstTransportation6 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]> lstTransportation7 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]>);
        protected Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]> lstTransportation8 = default(Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]>);
        protected DateTime timeView = DateTime.Now;
        protected Base.MessageChannel.MessageChannel msgChannel = null;

        protected virtual void initiate()
        {
            msgChannel = new Base.MessageChannel.MessageChannel();
            this.WebSoapHeader = new PTJSoapHeader() { CurrentUser = "Not Assigned", CurrentDataRole = "Not Assigned", CurrentRowLevelSecurity = "Not Assigned" };
            setInitiateObjects();
            setMessageChannel();
        }

        protected virtual void setInitiateObjects()
        {
            lstObjs = new List<object>();
            if (obj != null) { lstObjs.Add(obj); }
            if (obj1 != null) { lstObjs.Add(obj1); }
            if (obj2 != null) { lstObjs.Add(obj2); }
            if (obj3 != null) { lstObjs.Add(obj3); }
            if (obj4 != null) { lstObjs.Add(obj4); }
            if (obj5 != null) { lstObjs.Add(obj5); }
            if (obj6 != null) { lstObjs.Add(obj6); }
            if (obj7 != null) { lstObjs.Add(obj7); }
            if (obj8 != null) { lstObjs.Add(obj8); }
        }

        protected virtual List<Base.MessageChannel.Message> Messages(Exception ex)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getAll()
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = All();
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            } 
            return lstTransportation;
        }

        protected virtual T[] All()
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T> getById(I id)
        {
            try
            {
                if (IsAuthorised())
                {
                    transportation.Results = ById(id);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                transportation.Messages = msgChannel.GetClientMessages();
            } return transportation;
        }

        protected virtual T ById(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy1(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By1(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            } return lstTransportation;
        }

        protected virtual T[] By1(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy2(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                     lstTransportation.Results = By2(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By2(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy3(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By3(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By3(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy4(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By4(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By4(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy5(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By5(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By5(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy6(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By6(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By6(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy7(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By7(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By7(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> getBy8(object variable)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = By8(variable);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] By8(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]> getByObject1(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation1.Results = ByObject1(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation1.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation1;
        }

        protected virtual Base.Schemas.KeyValue<T, VO>[] ByObject1(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]> getByObject2(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation2.Results = ByObject2(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation2.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation2;
        }

        protected virtual Base.Schemas.KeyValue<T, WO>[] ByObject2(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]> getByObject3(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                   lstTransportation3.Results = ByObject3(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation3.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation3;
        }

        protected virtual Base.Schemas.KeyValue<T, XO>[] ByObject3(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]> getByObject4(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                     lstTransportation4.Results = ByObject4(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation4.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation4;
        }

        protected virtual Base.Schemas.KeyValue<T, YO>[] ByObject4(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]> getByObject5(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation5.Results = ByObject5(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation5.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation5;
        }

        protected virtual Base.Schemas.KeyValue<T, ZO>[] ByObject5(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]> getByObject6(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation6.Results = ByObject6(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation6.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation6;
        }

        protected virtual Base.Schemas.KeyValue<T, ÅO>[] ByObject6(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]> getByObject7(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation7.Results = ByObject7(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation7.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation7;
        }

        protected virtual Base.Schemas.KeyValue<T, ÄO>[] ByObject7(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]> getByObject8(object itemId)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation8.Results = ByObject8(itemId);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation8.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation8;
        }

        protected virtual Base.Schemas.KeyValue<T, ÖO>[] ByObject8(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> add(T[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    lstTransportation.Results = addItems(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] addItems(T[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]> add1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation1.Results = addItems1(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation1.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation1;
        }

        protected virtual Base.Schemas.KeyValue<T, VO>[] addItems1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]> add2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation2.Results = addItems2(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation2.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation2;
        }

        protected virtual Base.Schemas.KeyValue<T, WO>[] addItems2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]> add3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation3.Results = addItems3(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation3.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation3;
        }

        protected virtual Base.Schemas.KeyValue<T, XO>[] addItems3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]> add4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation4.Results = addItems4(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation4.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation4;
        }

        protected virtual Base.Schemas.KeyValue<T, YO>[] addItems4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]> add5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation5.Results = addItems5(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation5.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation5;
        }

        protected virtual Base.Schemas.KeyValue<T, ZO>[] addItems5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]> add6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation6.Results = addItems6(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation5.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation6;
        }

        protected virtual Base.Schemas.KeyValue<T, ÅO>[] addItems6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]> add7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation7.Results = addItems7(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation7.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation7;
        }

        protected virtual Base.Schemas.KeyValue<T, ÄO>[] addItems7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]> add8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation8.Results = addItems8(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation8.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation8;
        }

        protected virtual Base.Schemas.KeyValue<T, ÖO>[] addItems8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]> change1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                     using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation1.Results = changeItems1(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation1.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation1;
        }

        protected virtual Base.Schemas.KeyValue<T, VO>[] changeItems1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]> change2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation2.Results = changeItems2(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation2.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation2;
        }

        protected virtual Base.Schemas.KeyValue<T, WO>[] changeItems2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]> change3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation3.Results = changeItems3(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation3.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation3;
        }

        protected virtual Base.Schemas.KeyValue<T, XO>[] changeItems3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]> change4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation4.Results = changeItems4(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation4.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation4;
        }

        protected virtual Base.Schemas.KeyValue<T, YO>[] changeItems4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]> change5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation5.Results = changeItems5(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation5.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation5;
        }

        protected virtual Base.Schemas.KeyValue<T, ZO>[] changeItems5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]> change6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation6.Results = changeItems6(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation6.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation6;
        }

        protected virtual Base.Schemas.KeyValue<T, ÅO>[] changeItems6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]> change7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation7.Results = changeItems7(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation7.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation7;
        }

        protected virtual Base.Schemas.KeyValue<T, ÄO>[] changeItems7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]> change8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation8.Results = changeItems8(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation8.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation8;
        }

        protected virtual Base.Schemas.KeyValue<T, ÖO>[] changeItems8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, VO>[]> remove1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation1.Results = removeItems1(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation1.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation1;
        }

        protected virtual Base.Schemas.KeyValue<T, VO>[] removeItems1(Base.Schemas.KeyValue<T, VO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, WO>[]> remove2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation2.Results = removeItems2(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation2.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation2;
        }

        protected virtual Base.Schemas.KeyValue<T, WO>[] removeItems2(Base.Schemas.KeyValue<T, WO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, XO>[]> remove3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation3.Results = removeItems3(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation3.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation3;
        }

        protected virtual Base.Schemas.KeyValue<T, XO>[] removeItems3(Base.Schemas.KeyValue<T, XO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, YO>[]> remove4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation4.Results = removeItems4(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation4.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation4;
        }

        protected virtual Base.Schemas.KeyValue<T, YO>[] removeItems4(Base.Schemas.KeyValue<T, YO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ZO>[]> remove5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation5.Results = removeItems5(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation5.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation5;
        }

        protected virtual Base.Schemas.KeyValue<T, ZO>[] removeItems5(Base.Schemas.KeyValue<T, ZO>[] items)
        {
            throw new NotImplementedException();
        }
//****
        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÅO>[]> remove6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation6.Results = removeItems6(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation6.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation6;
        }

        protected virtual Base.Schemas.KeyValue<T, ÅO>[] removeItems6(Base.Schemas.KeyValue<T, ÅO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÄO>[]> remove7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation7.Results = removeItems7(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation7.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation7;
        }

        protected virtual Base.Schemas.KeyValue<T, ÄO>[] removeItems7(Base.Schemas.KeyValue<T, ÄO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<Base.Schemas.KeyValue<T, ÖO>[]> remove8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation8.Results = removeItems8(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation8.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation8;
        }

        protected virtual Base.Schemas.KeyValue<T, ÖO>[] removeItems8(Base.Schemas.KeyValue<T, ÖO>[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> change(T[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation.Results = changeItems(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] changeItems(T[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual Base.Schemas.TransportMessage<T[]> remove(T[] items)
        {
            try
            {
                if (IsAuthorised())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lstTransportation.Results = removeItems(items);
                        readyToCommit(scope);
                    }
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Abbend, ex.Message);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
                lstTransportation.Messages = msgChannel.GetClientMessages();
            }
            return lstTransportation;
        }

        protected virtual T[] removeItems(T[] items)
        {
            throw new NotImplementedException();
        }

        protected virtual bool IsAuthorised()
        {
            handleSoapHeaderInformation();
            
            if (this.CurrentUser != null)
            {
                return true;
            }
            else
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Security, "User =: " + CurrentUser + " isn not authorized!!!");
                return false;
            }
        }

        private void handleSoapHeaderInformation()
        {
            if (WebSoapHeader != null)
            {
                if (WebSoapHeader.TimeView != null && WebSoapHeader.TimeView != DateTime.MinValue)
                {
                    this.TimeView = WebSoapHeader.TimeView;
                }
                else
                {
                    this.TimeView = DateTime.Now;
                }
                if (WebSoapHeader.CurrentUser != null && WebSoapHeader.CurrentUser != "Not Assigned")
                {
                    CurrentUser = WebSoapHeader.CurrentUser;
                }
                else
                {
                    msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Security, "Not SoapHeader 'CurrentUser' is Set!!!");
                }
                if (WebSoapHeader.CurrentDataRole != null && WebSoapHeader.CurrentDataRole != "Not Assigned")
                {
                    CurrentDataRole = WebSoapHeader.CurrentDataRole;
                }
                else
                {
                    msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Security, "Not SoapHeader 'CurrentDataRole' is Set!!!");
                }
                if (WebSoapHeader.CurrentRowLevelSecurity != null)
                {
                    CurrentRowLevelSecurity = WebSoapHeader.CurrentRowLevelSecurity;
                }
            }
            else
            {
                msgChannel.AddMessage(Base.MessageChannel.Message.MessageType.Security, "Not SoapHeader Security is Set!!!");
            }
        }

        protected virtual void setTimeViewOnObjects(DateTime timeView)
        {
            throw new NotImplementedException();
        }

        protected virtual T Cast(D dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual D Cast(T schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual VO Cast(VD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual VD Cast(VO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual WO Cast(WD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual WD Cast(WO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual XO Cast(XD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual XD Cast(XO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual YO Cast(YD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual YD Cast(YO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ZO Cast(ZD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ZD Cast(ZO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÅO Cast(ÅD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÅD Cast(ÅO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÄO Cast(ÄD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÄD Cast(ÄO schemaItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÖO Cast(ÖD dataItem)
        {
            throw new NotImplementedException();
        }

        protected virtual ÖD Cast(ÖO schemaItem)
        {
            throw new NotImplementedException();
        }
        //protected virtual void setObjectTimeStamp()
        //{
        //    throw new NotImplementedException();
        //}

        protected virtual void setMessageChannel()
        {
            throw new NotImplementedException();
        }

        public virtual List<Base.MessageChannel.Message> getObjectMessages()
        {
            throw new NotImplementedException();
        }

        protected virtual DateTime TimeView
        {
            get { return this.timeView; }
            set { this.timeView = value; setTimeViewOnObjects(value); }
        }

        protected virtual bool isTimeViewSet()
        {
            return this.timeView > DateTime.Now.AddSeconds(10);
        }

        protected virtual void readyToCommit(TransactionScope scope)
        {
            if (msgChannel.isReadyToCommit())
            {
                scope.Complete();
            }
        }
    }

    public class PTJSoapHeader : SoapHeader
    {
        public DateTime TimeView;
        public string CurrentUser;
        public string CurrentDataRole;
        public string CurrentRowLevelSecurity;
    } 

    public class Nothing { }

}