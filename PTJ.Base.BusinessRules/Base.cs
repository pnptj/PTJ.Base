using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTJ.Base.BusinessRules
{
    public abstract class Base<I, O, T, VD, WD, XD, YD, ZD, ÅD, ÄD, ÖD>
    {
        protected O obj = default(O);
        protected List<T> lstResults = default(List<T>);
        protected T result = default(T);
        protected List<Schemas.KeyValue<T, VD>> lstResults1 = default(List<Schemas.KeyValue<T, VD>>);
        protected List<Schemas.KeyValue<T, WD>> lstResults2 = default(List<Schemas.KeyValue<T, WD>>);
        protected List<Schemas.KeyValue<T, XD>> lstResults3 = default(List<Schemas.KeyValue<T, XD>>);
        protected List<Schemas.KeyValue<T, YD>> lstResults4 = default(List<Schemas.KeyValue<T, YD>>);
        protected List<Schemas.KeyValue<T, ZD>> lstResults5 = default(List<Schemas.KeyValue<T, ZD>>);
        protected List<Schemas.KeyValue<T, ÅD>> lstResults6 = default(List<Schemas.KeyValue<T, ÅD>>);
        protected List<Schemas.KeyValue<T, ÄD>> lstResults7 = default(List<Schemas.KeyValue<T, ÄD>>);
        protected List<Schemas.KeyValue<T, ÖD>> lstResults8 = default(List<Schemas.KeyValue<T, ÖD>>);
        protected DateTime timeView = DateTime.Now;
        protected Base.MessageChannel.MessageChannel msgChannel = null;

        protected virtual void initiate() { throw new NotImplementedException(); }

        protected virtual List<T> getAll()
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = All();
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> All()
        {
            throw new NotImplementedException();
        }

        protected virtual T getById(I id)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                result = ById(id);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return default(T);
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return result;
        }

        protected virtual T ById(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy1(object variable)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = By1(variable);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> By1(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy2(object variable)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = By2(variable);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> By2(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy3(object variable)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = By3(variable);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> By3(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy4(object variable)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = By4(variable);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> By4(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy5(object variable)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults = By5(variable);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> By5(object variable)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, VD>> getByObject1(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults1 = byObject1(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults1;
        }

        protected virtual List<Schemas.KeyValue<T, VD>> byObject1(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, WD>> getByObject2(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults2 = byObject2(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults2;
        }

        protected virtual List<Schemas.KeyValue<T, WD>> byObject2(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, XD>> getByObject3(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults3 = byObject3(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults3;
        }

        protected virtual List<Schemas.KeyValue<T, XD>> byObject3(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, YD>> getByObject4(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults4 = byObject4(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults4;
        }

        protected virtual List<Schemas.KeyValue<T, YD>> byObject4(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> getByObject5(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults5 = byObject5(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults5;
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> byObject5(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ÅD>> getByObject6(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults6 = byObject6(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults6;
        }

        protected virtual List<Schemas.KeyValue<T, ÅD>> byObject6(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ÄD>> getByObject7(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults7 = byObject7(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults7;
        }

        protected virtual List<Schemas.KeyValue<T, ÄD>> byObject7(object itemId)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ÖD>> getByObject8(object itemId)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                lstResults8 = byObject8(itemId);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults8;
        }

        protected virtual List<Schemas.KeyValue<T, ÖD>> byObject8(object itemId)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists(List<T> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists(List<I> ids)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists1(Schemas.KeyValue<T, VD> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists1(List<Schemas.KeyValue<T, VD>> ids)
        {
            throw new NotImplementedException();
        }


        public virtual bool ItemsExists2(Schemas.KeyValue<T, WD> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists2(List<Schemas.KeyValue<T, WD>> ids)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists3(Schemas.KeyValue<T, XD> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists3(List<Schemas.KeyValue<T, XD>> ids)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists4(Schemas.KeyValue<T, YD> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists4(List<Schemas.KeyValue<T, YD>> ids)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists5(Schemas.KeyValue<T, ZD> items)
        {
            throw new NotImplementedException();
        }

        public virtual bool ItemsExists5(List<Schemas.KeyValue<T, ZD>> ids)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> add(List<T> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists(items))
                {
                    lstResults = addItems(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items already exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> addItems(List<T> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, VD>> add1(List<Schemas.KeyValue<T, VD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists1(items))
                {
                    lstResults1 = addItems1(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults1;
        }

        protected virtual List<Schemas.KeyValue<T, VD>> addItems1(List<Schemas.KeyValue<T, VD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, WD>> add2(List<Schemas.KeyValue<T, WD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists2(items))
                {
                    lstResults2 = addItems2(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults2;
        }

        protected virtual List<Schemas.KeyValue<T, WD>> addItems2(List<Schemas.KeyValue<T, WD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, XD>> add3(List<Schemas.KeyValue<T, XD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists3(items))
                {
                    lstResults3 = addItems3(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults3;
        }

        protected virtual List<Schemas.KeyValue<T, XD>> addItems3(List<Schemas.KeyValue<T, XD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, YD>> add4(List<Schemas.KeyValue<T, YD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists4(items))
                {
                    lstResults4 = addItems4(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults4;
        }

        protected virtual List<Schemas.KeyValue<T, YD>> addItems4(List<Schemas.KeyValue<T, YD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> add5(List<Schemas.KeyValue<T, ZD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (!ItemsExists5(items))
                {
                    lstResults5 = addItems5(items);
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults5;
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> addItems5(List<Schemas.KeyValue<T, ZD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> change(List<T> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists(items))
                {
                    lstResults = changeItems(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> changeItems(List<T> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, VD>> change1(List<Schemas.KeyValue<T, VD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists1(items))
                {
                    lstResults1 = changeItems1(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults1;
        }

        protected virtual List<Schemas.KeyValue<T, VD>> changeItems1(List<Schemas.KeyValue<T, VD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, WD>> change2(List<Schemas.KeyValue<T, WD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists2(items))
                {
                    lstResults2 = changeItems2(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults2;
        }

        protected virtual List<Schemas.KeyValue<T, WD>> changeItems2(List<Schemas.KeyValue<T, WD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, XD>> change3(List<Schemas.KeyValue<T, XD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists3(items))
                {
                    lstResults3 = changeItems3(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults3;
        }

        protected virtual List<Schemas.KeyValue<T, XD>> changeItems3(List<Schemas.KeyValue<T, XD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, YD>> change4(List<Schemas.KeyValue<T, YD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists4(items))
                {
                    lstResults4 = changeItems4(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults4;
        }

        protected virtual List<Schemas.KeyValue<T, YD>> changeItems4(List<Schemas.KeyValue<T, YD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> change5(List<Schemas.KeyValue<T, ZD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists5(items))
                {
                    lstResults5 = changeItems5(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults5;
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> changeItems5(List<Schemas.KeyValue<T, ZD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> remove(List<T> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists(items))
                {
                    lstResults = removeItems(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults;
        }

        protected virtual List<T> removeItems(List<T> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, VD>> remove1(List<Schemas.KeyValue<T, VD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists1(items))
                {
                    lstResults1 = removeItems1(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults1;
        }

        protected virtual List<Schemas.KeyValue<T, VD>> removeItems1(List<Schemas.KeyValue<T, VD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, WD>> remove2(List<Schemas.KeyValue<T, WD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists2(items))
                {
                    lstResults2 = removeItems2(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults2;
        }

        protected virtual List<Schemas.KeyValue<T, WD>> removeItems2(List<Schemas.KeyValue<T, WD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, XD>> remove3(List<Schemas.KeyValue<T, XD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists3(items))
                {
                    lstResults3 = removeItems3(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults3;
        }

        protected virtual List<Schemas.KeyValue<T, XD>> removeItems3(List<Schemas.KeyValue<T, XD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, YD>> remove4(List<Schemas.KeyValue<T, YD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists4(items))
                {
                    lstResults4 = removeItems4(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults4;
        }

        protected virtual List<Schemas.KeyValue<T, YD>> removeItems4(List<Schemas.KeyValue<T, YD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> remove5(List<Schemas.KeyValue<T, ZD>> items)
        {
            try
            {
                setObjectTimeStamp(); setMessageChannel();

                if (ItemsExists5(items))
                {
                    lstResults5 = removeItems5(items);
                }
                else
                {
                    msgChannel.AddMessage(MessageChannel.Message.MessageType.Validation, this.GetType().ToString() + "; Items doesn't exists!!!");
                }
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
            finally
            {
                msgChannel.Merge(getObjectMessages());
            }
            return lstResults5;
        }

        protected virtual List<Schemas.KeyValue<T, ZD>> removeItems5(List<Schemas.KeyValue<T, ZD>> items)
        {
            throw new NotImplementedException();
        }

        protected virtual void setObjectTimeStamp()
        {
            throw new NotImplementedException();
        }

        public virtual DateTime TimeView
        {
            get { return this.timeView; }
            set { this.timeView = value; }
        }

        public virtual bool isTimeViewSet()
        {
            return this.timeView != DateTime.Now;
        }

        protected virtual void setMessageChannel()
        {
            throw new NotImplementedException();
        }

        public virtual MessageChannel.MessageChannel MsgChannel
        {
            get { return this.msgChannel; }
            set { this.msgChannel = value; }
        }

        public virtual List<MessageChannel.Message> getObjectMessages()
        {
            throw new NotImplementedException();
        }
    }

    public class Nothing { }
}
