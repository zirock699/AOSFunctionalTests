<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>CustomerModel</className>
  <objects>
    <object technology="Standard Windows" type="Window">
      <name> Google Chrome</name>
      <codeName>GoogleChromeWindow</codeName>
      <description />
      <identification>
        <properties>
          <property name="WindowTitleRegExp" type="string"> Google Chrome</property>
          <property name="WindowClassRegExp" type="string">Chrome_WidgetWin_1</property>
          <property name="IsOwnedWindow" type="boolean">false</property>
          <property name="IsChildWindow" type="boolean">false</property>
        </properties>
      </identification>
      <children>
        <object technology="Standard Windows" type="UiObject">
          <name>Chrome Legacy Window</name>
          <codeName>ChromeLegacyWindowUiObject</codeName>
          <description />
          <identification>
            <properties>
              <property name="WindowClassRegExp" type="string">Chrome_RenderWidgetHostHWND</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>