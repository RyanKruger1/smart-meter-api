/*
 * This class file was automatically generated by ASN1bean (http://www.beanit.com)
 */

package com.beanit.iec61850bean.internal.mms.asn1;

import com.beanit.asn1bean.ber.BerLength;
import com.beanit.asn1bean.ber.BerTag;
import com.beanit.asn1bean.ber.ReverseByteArrayOutputStream;
import com.beanit.asn1bean.ber.types.BerInteger;
import com.beanit.asn1bean.ber.types.BerType;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.Serializable;

public class RejectPDU implements BerType, Serializable {

  public static final BerTag tag = new BerTag(BerTag.UNIVERSAL_CLASS, BerTag.CONSTRUCTED, 16);
  private static final long serialVersionUID = 1L;
  private byte[] code = null;
  private Unsigned32 originalInvokeID = null;
  private RejectReason rejectReason = null;

  public RejectPDU() {}

  public RejectPDU(byte[] code) {
    this.code = code;
  }

  public Unsigned32 getOriginalInvokeID() {
    return originalInvokeID;
  }

  public void setOriginalInvokeID(Unsigned32 originalInvokeID) {
    this.originalInvokeID = originalInvokeID;
  }

  public RejectReason getRejectReason() {
    return rejectReason;
  }

  public void setRejectReason(RejectReason rejectReason) {
    this.rejectReason = rejectReason;
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
    codeLength += rejectReason.encode(reverseOS);

    if (originalInvokeID != null) {
      codeLength += originalInvokeID.encode(reverseOS, false);
      // write tag: CONTEXT_CLASS, PRIMITIVE, 0
      reverseOS.write(0x80);
      codeLength += 1;
    }

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
    int numDecodedBytes;
    BerTag berTag = new BerTag();

    if (withTag) {
      tlByteCount += tag.decodeAndCheck(is);
    }

    BerLength length = new BerLength();
    tlByteCount += length.decode(is);
    int lengthVal = length.val;
    vByteCount += berTag.decode(is);

    if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 0)) {
      originalInvokeID = new Unsigned32();
      vByteCount += originalInvokeID.decode(is, false);
      vByteCount += berTag.decode(is);
    }

    rejectReason = new RejectReason();
    numDecodedBytes = rejectReason.decode(is, berTag);
    if (numDecodedBytes != 0) {
      vByteCount += numDecodedBytes;
      if (lengthVal >= 0 && vByteCount == lengthVal) {
        return tlByteCount + vByteCount;
      }
      vByteCount += berTag.decode(is);
    } else {
      throw new IOException("Tag does not match mandatory sequence component.");
    }
    if (lengthVal < 0) {
      if (!berTag.equals(0, 0, 0)) {
        throw new IOException("Decoded sequence has wrong end of contents octets");
      }
      vByteCount += BerLength.readEocByte(is);
      return tlByteCount + vByteCount;
    }

    throw new IOException(
        "Unexpected end of sequence, length tag: " + lengthVal + ", bytes decoded: " + vByteCount);
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
    boolean firstSelectedElement = true;
    if (originalInvokeID != null) {
      sb.append("\n");
      for (int i = 0; i < indentLevel + 1; i++) {
        sb.append("\t");
      }
      sb.append("originalInvokeID: ").append(originalInvokeID);
      firstSelectedElement = false;
    }

    if (!firstSelectedElement) {
      sb.append(",\n");
    }
    for (int i = 0; i < indentLevel + 1; i++) {
      sb.append("\t");
    }
    if (rejectReason != null) {
      sb.append("rejectReason: ");
      rejectReason.appendAsString(sb, indentLevel + 1);
    } else {
      sb.append("rejectReason: <empty-required-field>");
    }

    sb.append("\n");
    for (int i = 0; i < indentLevel; i++) {
      sb.append("\t");
    }
    sb.append("}");
  }

  public static class RejectReason implements BerType, Serializable {

    private static final long serialVersionUID = 1L;

    private byte[] code = null;
    private BerInteger confirmedRequestPDU = null;
    private BerInteger confirmedResponsePDU = null;
    private BerInteger confirmedErrorPDU = null;
    private BerInteger unconfirmedPDU = null;
    private BerInteger pduError = null;
    private BerInteger cancelRequestPDU = null;
    private BerInteger cancelResponsePDU = null;
    private BerInteger cancelErrorPDU = null;
    private BerInteger concludeRequestPDU = null;
    private BerInteger concludeResponsePDU = null;
    private BerInteger concludeErrorPDU = null;

    public RejectReason() {}

    public RejectReason(byte[] code) {
      this.code = code;
    }

    public BerInteger getConfirmedRequestPDU() {
      return confirmedRequestPDU;
    }

    public void setConfirmedRequestPDU(BerInteger confirmedRequestPDU) {
      this.confirmedRequestPDU = confirmedRequestPDU;
    }

    public BerInteger getConfirmedResponsePDU() {
      return confirmedResponsePDU;
    }

    public void setConfirmedResponsePDU(BerInteger confirmedResponsePDU) {
      this.confirmedResponsePDU = confirmedResponsePDU;
    }

    public BerInteger getConfirmedErrorPDU() {
      return confirmedErrorPDU;
    }

    public void setConfirmedErrorPDU(BerInteger confirmedErrorPDU) {
      this.confirmedErrorPDU = confirmedErrorPDU;
    }

    public BerInteger getUnconfirmedPDU() {
      return unconfirmedPDU;
    }

    public void setUnconfirmedPDU(BerInteger unconfirmedPDU) {
      this.unconfirmedPDU = unconfirmedPDU;
    }

    public BerInteger getPduError() {
      return pduError;
    }

    public void setPduError(BerInteger pduError) {
      this.pduError = pduError;
    }

    public BerInteger getCancelRequestPDU() {
      return cancelRequestPDU;
    }

    public void setCancelRequestPDU(BerInteger cancelRequestPDU) {
      this.cancelRequestPDU = cancelRequestPDU;
    }

    public BerInteger getCancelResponsePDU() {
      return cancelResponsePDU;
    }

    public void setCancelResponsePDU(BerInteger cancelResponsePDU) {
      this.cancelResponsePDU = cancelResponsePDU;
    }

    public BerInteger getCancelErrorPDU() {
      return cancelErrorPDU;
    }

    public void setCancelErrorPDU(BerInteger cancelErrorPDU) {
      this.cancelErrorPDU = cancelErrorPDU;
    }

    public BerInteger getConcludeRequestPDU() {
      return concludeRequestPDU;
    }

    public void setConcludeRequestPDU(BerInteger concludeRequestPDU) {
      this.concludeRequestPDU = concludeRequestPDU;
    }

    public BerInteger getConcludeResponsePDU() {
      return concludeResponsePDU;
    }

    public void setConcludeResponsePDU(BerInteger concludeResponsePDU) {
      this.concludeResponsePDU = concludeResponsePDU;
    }

    public BerInteger getConcludeErrorPDU() {
      return concludeErrorPDU;
    }

    public void setConcludeErrorPDU(BerInteger concludeErrorPDU) {
      this.concludeErrorPDU = concludeErrorPDU;
    }

    @Override
    public int encode(OutputStream reverseOS) throws IOException {

      if (code != null) {
        reverseOS.write(code);
        return code.length;
      }

      int codeLength = 0;
      if (concludeErrorPDU != null) {
        codeLength += concludeErrorPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 11
        reverseOS.write(0x8B);
        codeLength += 1;
        return codeLength;
      }

      if (concludeResponsePDU != null) {
        codeLength += concludeResponsePDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 10
        reverseOS.write(0x8A);
        codeLength += 1;
        return codeLength;
      }

      if (concludeRequestPDU != null) {
        codeLength += concludeRequestPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 9
        reverseOS.write(0x89);
        codeLength += 1;
        return codeLength;
      }

      if (cancelErrorPDU != null) {
        codeLength += cancelErrorPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 8
        reverseOS.write(0x88);
        codeLength += 1;
        return codeLength;
      }

      if (cancelResponsePDU != null) {
        codeLength += cancelResponsePDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 7
        reverseOS.write(0x87);
        codeLength += 1;
        return codeLength;
      }

      if (cancelRequestPDU != null) {
        codeLength += cancelRequestPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 6
        reverseOS.write(0x86);
        codeLength += 1;
        return codeLength;
      }

      if (pduError != null) {
        codeLength += pduError.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 5
        reverseOS.write(0x85);
        codeLength += 1;
        return codeLength;
      }

      if (unconfirmedPDU != null) {
        codeLength += unconfirmedPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 4
        reverseOS.write(0x84);
        codeLength += 1;
        return codeLength;
      }

      if (confirmedErrorPDU != null) {
        codeLength += confirmedErrorPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 3
        reverseOS.write(0x83);
        codeLength += 1;
        return codeLength;
      }

      if (confirmedResponsePDU != null) {
        codeLength += confirmedResponsePDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 2
        reverseOS.write(0x82);
        codeLength += 1;
        return codeLength;
      }

      if (confirmedRequestPDU != null) {
        codeLength += confirmedRequestPDU.encode(reverseOS, false);
        // write tag: CONTEXT_CLASS, PRIMITIVE, 1
        reverseOS.write(0x81);
        codeLength += 1;
        return codeLength;
      }

      throw new IOException("Error encoding CHOICE: No element of CHOICE was selected.");
    }

    @Override
    public int decode(InputStream is) throws IOException {
      return decode(is, null);
    }

    public int decode(InputStream is, BerTag berTag) throws IOException {

      int tlvByteCount = 0;
      boolean tagWasPassed = (berTag != null);

      if (berTag == null) {
        berTag = new BerTag();
        tlvByteCount += berTag.decode(is);
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 1)) {
        confirmedRequestPDU = new BerInteger();
        tlvByteCount += confirmedRequestPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 2)) {
        confirmedResponsePDU = new BerInteger();
        tlvByteCount += confirmedResponsePDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 3)) {
        confirmedErrorPDU = new BerInteger();
        tlvByteCount += confirmedErrorPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 4)) {
        unconfirmedPDU = new BerInteger();
        tlvByteCount += unconfirmedPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 5)) {
        pduError = new BerInteger();
        tlvByteCount += pduError.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 6)) {
        cancelRequestPDU = new BerInteger();
        tlvByteCount += cancelRequestPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 7)) {
        cancelResponsePDU = new BerInteger();
        tlvByteCount += cancelResponsePDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 8)) {
        cancelErrorPDU = new BerInteger();
        tlvByteCount += cancelErrorPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 9)) {
        concludeRequestPDU = new BerInteger();
        tlvByteCount += concludeRequestPDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 10)) {
        concludeResponsePDU = new BerInteger();
        tlvByteCount += concludeResponsePDU.decode(is, false);
        return tlvByteCount;
      }

      if (berTag.equals(BerTag.CONTEXT_CLASS, BerTag.PRIMITIVE, 11)) {
        concludeErrorPDU = new BerInteger();
        tlvByteCount += concludeErrorPDU.decode(is, false);
        return tlvByteCount;
      }

      if (tagWasPassed) {
        return 0;
      }

      throw new IOException("Error decoding CHOICE: Tag " + berTag + " matched to no item.");
    }

    public void encodeAndSave(int encodingSizeGuess) throws IOException {
      ReverseByteArrayOutputStream reverseOS = new ReverseByteArrayOutputStream(encodingSizeGuess);
      encode(reverseOS);
      code = reverseOS.getArray();
    }

    @Override
    public String toString() {
      StringBuilder sb = new StringBuilder();
      appendAsString(sb, 0);
      return sb.toString();
    }

    public void appendAsString(StringBuilder sb, int indentLevel) {

      if (confirmedRequestPDU != null) {
        sb.append("confirmedRequestPDU: ").append(confirmedRequestPDU);
        return;
      }

      if (confirmedResponsePDU != null) {
        sb.append("confirmedResponsePDU: ").append(confirmedResponsePDU);
        return;
      }

      if (confirmedErrorPDU != null) {
        sb.append("confirmedErrorPDU: ").append(confirmedErrorPDU);
        return;
      }

      if (unconfirmedPDU != null) {
        sb.append("unconfirmedPDU: ").append(unconfirmedPDU);
        return;
      }

      if (pduError != null) {
        sb.append("pduError: ").append(pduError);
        return;
      }

      if (cancelRequestPDU != null) {
        sb.append("cancelRequestPDU: ").append(cancelRequestPDU);
        return;
      }

      if (cancelResponsePDU != null) {
        sb.append("cancelResponsePDU: ").append(cancelResponsePDU);
        return;
      }

      if (cancelErrorPDU != null) {
        sb.append("cancelErrorPDU: ").append(cancelErrorPDU);
        return;
      }

      if (concludeRequestPDU != null) {
        sb.append("concludeRequestPDU: ").append(concludeRequestPDU);
        return;
      }

      if (concludeResponsePDU != null) {
        sb.append("concludeResponsePDU: ").append(concludeResponsePDU);
        return;
      }

      if (concludeErrorPDU != null) {
        sb.append("concludeErrorPDU: ").append(concludeErrorPDU);
        return;
      }

      sb.append("<none>");
    }
  }
}
