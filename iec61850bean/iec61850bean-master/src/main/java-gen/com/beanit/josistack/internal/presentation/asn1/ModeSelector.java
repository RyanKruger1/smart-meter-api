/*
 * This class file was automatically generated by ASN1bean (http://www.beanit.com)
 */

package com.beanit.josistack.internal.presentation.asn1;

import com.beanit.asn1bean.ber.BerLength;
import com.beanit.asn1bean.ber.BerTag;
import com.beanit.asn1bean.ber.ReverseByteArrayOutputStream;
import com.beanit.asn1bean.ber.types.BerInteger;
import com.beanit.asn1bean.ber.types.BerType;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.Serializable;

public class ModeSelector implements BerType, Serializable {

  public static final BerTag tag = new BerTag(BerTag.UNIVERSAL_CLASS, BerTag.CONSTRUCTED, 17);
  private static final long serialVersionUID = 1L;
  private byte[] code = null;
  private BerInteger modeValue = null;

  public ModeSelector() {}

  public ModeSelector(byte[] code) {
    this.code = code;
  }

  public BerInteger getModeValue() {
    return modeValue;
  }

  public void setModeValue(BerInteger modeValue) {
    this.modeValue = modeValue;
  }

  @Override
  public int encode(OutputStream reverseOS) throws IOException {
    return encode(reverseOS, true);
  }

  public int encode(OutputStream reverseOS, boolean withTag) throws IOException {

    if (code != null) {
      reverseOS.write(code);
      if (withTag) {
        return tag.encode(reverseOS) + code.length;
      }
      return code.length;
    }

    int codeLength = 0;
    codeLength += modeValue.encode(reverseOS, false);
    // write tag: CONTEXT_CLASS, PRIMITIVE, 0
    reverseOS.write(0x80);
    codeLength += 1;

    codeLength += BerLength.encodeLength(reverseOS, codeLength);

    if (withTag) {
      codeLength += tag.encode(reverseOS);
    }

    return codeLength;
  }

  @Override
  public int decode(InputStream is) throws IOException {
    return decode(is, true);
  }

  public int decode(InputStream is, boolean withTag) throws IOException {
    int tlByteCount = 0;
    int vByteCount = 0;
    BerTag berTag = new BerTag();

    if (withTag) {
      tlByteCount += tag.decodeAndCheck(is);
    }

    BerLength length = new BerLength();
    tlByteCount += length.decode(is);
    int lengthVal = length.val;

    while (vByteCount < lengthVal || lengthVal < 0) {
      vByteCount += berTag.decode(is);
      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 0)) {
        modeValue = new BerInteger();
        vByteCount += modeValue.decode(is, false);
      } else if (lengthVal < 0 && berTag.equals(0, 0, 0)) {
        vByteCount += BerLength.readEocByte(is);
        return tlByteCount + vByteCount;
      } else {
        throw new IOException("Tag does not match any set component: " + berTag);
      }
    }
    if (vByteCount != lengthVal) {
      throw new IOException(
          "Length of set does not match length tag, length tag: "
              + lengthVal
              + ", actual set length: "
              + vByteCount);
    }
    return tlByteCount + vByteCount;
  }

  public void encodeAndSave(int encodingSizeGuess) throws IOException {
    ReverseByteArrayOutputStream reverseOS = new ReverseByteArrayOutputStream(encodingSizeGuess);
    encode(reverseOS, false);
    code = reverseOS.getArray();
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    appendAsString(sb, 0);
    return sb.toString();
  }

  public void appendAsString(StringBuilder sb, int indentLevel) {

    sb.append("{");
    sb.append("\n");
    for (int i = 0; i < indentLevel + 1; i++) {
      sb.append("\t");
    }
    if (modeValue != null) {
      sb.append("modeValue: ").append(modeValue);
    } else {
      sb.append("modeValue: <empty-required-field>");
    }

    sb.append("\n");
    for (int i = 0; i < indentLevel; i++) {
      sb.append("\t");
    }
    sb.append("}");
  }
}